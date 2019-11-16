using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    public QuestionPanelController canvasControl;


    public void Handle(Interactable tile)
    {
        string[] texts = File.ReadAllLines($"Assets/Dialogues/{tile.questionFileName}.txt");

        foreach (string s in texts)
        {
            Debug.Log(s);
        }

        switch (tile.type)
        {
            case InteractType.Start:
                canvasControl.Toggle();
                break;
            case InteractType.Road:
                Debug.Log("Road");
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
