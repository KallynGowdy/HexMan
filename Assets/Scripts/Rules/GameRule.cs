using UnityEngine;
using System.Collections;

/// <summary>
/// Defines a component that represents a rule in the game.
/// </summary>
public sealed class GameRule : MonoBehaviour
{
    public RuleCondition Condition = null;
    public RuleAction Action = null;

    public void Apply(RuleData data)
    {
        if (Action != null && (Condition == null || Condition.Matches(data)))
        {
            Action.Apply(data);
        }
    }
}
