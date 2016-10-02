using UnityEngine;
using System.Collections;

/// <summary>
/// Defines a component that is able to affect the world in response to a rule condition.
/// </summary>
public abstract class RuleAction : MonoBehaviour
{
    /// <summary>
    /// Applies the action of the rule.
    /// </summary>
    /// <param name="data"></param>
    public abstract void Apply(RuleData data);
}
