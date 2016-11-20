using UnityEngine;
using System.Collections;
using System.Linq;

public class DestroyDotAction : DestroyObjectAction
{
    private int dotsLeft;

    void Start()
    {
        dotsLeft = FindObjectsOfType<Dot>().Length;
    }

    public override bool Apply(RuleData data)
    {
        base.Apply(data);
        dotsLeft--;
        if (dotsLeft <= 0)
        {
            data.DidWin = true;
        }
        return true;
    }
}
