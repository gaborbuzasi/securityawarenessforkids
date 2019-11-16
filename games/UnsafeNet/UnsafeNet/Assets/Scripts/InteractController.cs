using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    public QuestionPanelController canvasControl;

    private string[] texts;
    private Interactable interactable;

    public void Handle(Interactable tile)
    {
        interactable = tile;
        texts = File.ReadAllLines($"Assets/Dialogues/{tile.questionFileName}.txt");
        canvasControl.StartQuestion(texts);
        
    }

    public void DisplayBadResponse()
    {
        canvasControl.DisableButtons();
        canvasControl.SetTitle(texts[4]);
        HandleResult(false);
    }

    public void DisplayCorrectResponse()
    {
        canvasControl.DisableButtons();
        canvasControl.SetTitle(texts[3]);
        HandleResult(true);
    }

    public void Close()
    {
        canvasControl.Disable();
    }

    private void HandleResult(bool result)
    {
        switch (interactable.type)
        {
            case InteractType.Start:
                if (result)
                {
                    interactable.transform.GetChild(0).transform.position += Vector3.down * 3;
                }
                break;
            case InteractType.Road:
                break;
            case InteractType.EvilCastle:
                break;
            case InteractType.GoodCastle:
                break;
            case InteractType.Factory:
                break;
            case InteractType.Farm:
                break;
            case InteractType.CandyLand:
                break;
            default:
                break;
        }
    }
}
