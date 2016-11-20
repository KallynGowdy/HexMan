using UnityEngine;
using System.Collections;

public class DestroyObjectAction : RuleAction
{
    public override bool Apply(RuleData data)
    {
        DestroyObject(data.Collider);
        return true;
    }
}
