using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainOverlayController : MonoBehaviour
{
    public Duck duck;

    private List<Text> texts;

    // Start is called before the first frame update
    void Start()
    {
        texts = GetComponentsInChildren<Text>().ToList();
    }

    // Update is called once per frame
    void Update()
    {
        texts[0].text = $"Keys: {duck.keyCount}";
        texts[1].text = $"Lives: {duck.health}";
    }
}
