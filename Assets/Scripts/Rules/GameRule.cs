using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Defines a component that represents a rule in the game.
/// </summary>
public sealed class GameRule : MonoBehaviour
{
    public RuleCondition Condition = null;
    public RuleAction[] Actions = new RuleAction[0];

    public void Apply(RuleData data)
    {
        if ((Condition == null || Condition.Matches(data)))
        {
            foreach (var action in Actions)
            {
                action.Apply(data);
            }
        }
    }
}
