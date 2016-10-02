using UnityEngine;
using System.Collections;

/// <summary>
/// Defines an action that is able apply the effect of eating a super dot.
/// </summary>
public class EatSuperDotAction : RuleAction
{
    public float SuperTime = 5f;

    public override void Apply(RuleData data)
    {
        data.Player.SetSuperTimeLeft(SuperTime);
        DestroyObject(data.Collider);
        data.Collider = null;
    }
}
