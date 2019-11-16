using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class QuestionPanelController : MonoBehaviour
{
    private Canvas canvas;
    private string[] questionTexts;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    public void StartQuestion(string[] texts)
    {
        questionTexts = texts;
        Enable();

        int i = 0;
        foreach (var child in transform.GetComponentsInChildren<Text>())
        {
            child.text = questionTexts[i++];
        }
    }


    public void EnableButtons()
    {
        foreach (var item in transform.GetComponentsInChildren<Button>())
        {
            item.enabled = true;
            item.GetComponentInParent<Image>().enabled = true;
        }
    }

    public void DisableButtons()
    {
        foreach (var item in transform.GetComponentsInChildren<Button>())
        {
            item.enabled = false;
            item.GetComponentInParent<Image>().enabled = false;
            item.GetComponentInChildren<Text>().text = "";
        }
    }

    public void SetTitle(string text)
    {
        GetComponentInChildren<Text>().text = text;
    }

    public void Enable()
    {
        canvas.enabled = true;
        EnableButtons();
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
