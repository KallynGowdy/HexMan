using UnityEngine;
using System.Collections;

/// <summary>
/// Defines a rule that is able to handle when a player hits a dot.
/// </summary>
public class EatDotRule : PlayerTriggerRule
{
    public int Value = 10;

    protected override void ApplyCore(Player player, GameObject other)
    {
        player.Score += Value;
        DestroyObject(other);
    }
}
