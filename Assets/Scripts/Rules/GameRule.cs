using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Defines a component that represents a rule in the game.
/// </summary>
public sealed class GameRule : RuleAction
{
    public RuleAction[] Actions = new RuleAction[0];

    public override bool Apply(RuleData data)
    {
        return Actions.All(a => a.Apply(data));
    }
}
