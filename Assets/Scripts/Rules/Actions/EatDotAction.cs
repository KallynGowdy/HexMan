using UnityEngine;
using System.Collections;

/// <summary>
/// Defines an action that is able to apply the effect of eating a dot.
/// </summary>
public class EatDotAction : RuleAction
{
    public int Value = 10;

    public override void Apply(RuleData data)
    {
        data.Player.Score += Value;
        DestroyObject(data.Collider);
        data.Collider = null;
    }
}
