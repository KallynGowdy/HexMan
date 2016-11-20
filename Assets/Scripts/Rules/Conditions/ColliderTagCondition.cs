using UnityEngine;
using System.Collections;

/// <summary>
/// Defines a generic rule that is able to determine whether a collider matches a tag.
/// </summary>
public sealed class ColliderTagCondition : RuleAction
{
    public string Tag = "";

    public override bool Apply(RuleData data)
    {
        var c = data.Collider;
        return c != null && c.CompareTag(Tag);
    }
}
