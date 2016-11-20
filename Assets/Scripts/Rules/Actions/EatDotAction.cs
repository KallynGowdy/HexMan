using UnityEngine;
using System.Collections;

/// <summary>
/// Defines an action that is able to apply the effect of eating a dot.
/// </summary>
public class EatDotAction : RuleAction
{
    public override bool Apply(RuleData data)
    {
        var value = data.Collider.GetComponent<Dot>().Value;
        data.Player.Score += value;
        return true;
    }
}
