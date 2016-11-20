using UnityEngine;
using System.Collections;

public class All : FlowAction
{
    public override bool Apply(RuleData data)
    {
        foreach (var a in Actions)
        {
            a.Apply(data);
        }
        return true;
    }
}
