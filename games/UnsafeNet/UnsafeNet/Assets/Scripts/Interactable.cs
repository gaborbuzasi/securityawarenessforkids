using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InteractType
{
    Start,
    Road,
    EvilCastle,
    GoodCastle,
    Factory,
    Farm,
    CandyLand
}

public class Interactable : MonoBehaviour
{
    public InteractType type;
    public string questionFileName;
}
