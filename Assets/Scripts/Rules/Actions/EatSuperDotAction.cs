using UnityEngine;
using System.Collections;

/// <summary>
/// Defines an action that is able apply the effect of eating a super dot.
/// </summary>
public class EatSuperDotAction : RuleAction
{

    public override bool Apply(RuleData data)
    {
        var superTime = data.Collider.GetComponent<SuperDot>().Timeout;
        data.Player.SetSuperTimeLeft(superTime);
        return true;
    }
}
