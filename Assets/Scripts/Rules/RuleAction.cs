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
    /// <returns>Whether the action was successfully applied.</returns>
    public abstract bool Apply(RuleData data);
}
