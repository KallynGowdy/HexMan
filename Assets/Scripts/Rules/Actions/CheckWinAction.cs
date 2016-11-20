using System;
using UnityEngine;
using System.Collections;
using System.Linq;

public class CheckWinAction : RuleAction
{
    private int dotsLeft;

    void Start()
    {
        dotsLeft = FindObjectsOfType<Dot>().Length;
    }

    public override void Apply(RuleData data)
    {
        dotsLeft--;
    }

    void Update()
    {
        if (dotsLeft <= 0)
        {
            Debug.Log("Win!");
        }
    }
}
