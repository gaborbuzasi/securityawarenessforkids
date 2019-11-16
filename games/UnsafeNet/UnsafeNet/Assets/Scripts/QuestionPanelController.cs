using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionPanelController : MonoBehaviour
{
    private Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();

        canvas.enabled = false;
    }

    public void DisplayQuestion(Interactable tile)
    {
        //transform.GetChild(0).GetComponent<Text>().text = tile.questionText;
        //transform.GetChild(1).GetComponent<Text>().text = 
    }

    public void Enable()
    {
        canvas.enabled = true;
    }

    public void Disable()
    {
        canvas.enabled = false;
    }

    public void Toggle()
    {
        canvas.enabled = !canvas.enabled;
    }
}
