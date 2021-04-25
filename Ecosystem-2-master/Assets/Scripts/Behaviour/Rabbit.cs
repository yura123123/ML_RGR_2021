using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : Animal {
    public static readonly string[] GeneNames = { "A", "B" };

    float amountRemaining = 1;
    const float consumeSpeed = 8;

    public float AmountRemaining
    {
        get
        {
            return amountRemaining;
        }
    }
}