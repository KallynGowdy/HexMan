using UnityEngine;
using System.Collections;

/// <summary>
/// Defines a generic rule that is able to handle collision triggers with the player.
/// </summary>
public abstract class PlayerTriggerRule : GameRule
{
    public string Tag = "";

    /// <summary>
    /// Applies the rule to the given player and object.
    /// </summary>
    /// <param name="data">That data for the event.</param>
    public override void Apply(RuleData data)
    {
        if (data.Collider.CompareTag(Tag))
        {
            ApplyCore(data.Player, data.Collider);
        }
    }

    /// <summary>
    /// Applies the rule to the given player and object.
    /// </summary>
    /// <param name="player">The player that hit the other object's trigger.</param>
    /// <param name="other">The other object that got triggered.</param>
    protected abstract void ApplyCore(Player player, GameObject other);
}
