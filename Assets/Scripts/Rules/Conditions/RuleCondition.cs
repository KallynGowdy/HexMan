using UnityEngine;
using System.Collections;

/// <summary>
/// Defines a component that controls whether a rule's action is performed or not.
/// </summary>
public abstract class RuleCondition : MonoBehaviour
{
    /// <summary>
    /// Determines whether the action should be performed for the given rule data.
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public abstract bool Matches(RuleData data);
}
