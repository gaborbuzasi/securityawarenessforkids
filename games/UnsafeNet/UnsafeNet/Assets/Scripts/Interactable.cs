using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InteractType
{
    Start,
    Road,
    Bridge,
    EvilCastle,
    GoodCastle,
    Factory,
    Farm,
    CandyLand,
    Forest,
    Empty
}

public class Interactable : MonoBehaviour
{
    public InteractType type;
    public string questionFileName;
    public bool finished;
}
