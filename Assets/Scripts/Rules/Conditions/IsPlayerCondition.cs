using UnityEngine;
using System.Collections;

/// <summary>
/// Defines a rule condition that asserts that the character involved in the rule is a player.
/// </summary>
public class IsPlayerCondition : RuleAction
{
    public override bool Apply(RuleData data)
    {
        return data.Player != null;
    }
}
