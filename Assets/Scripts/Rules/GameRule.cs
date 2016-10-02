using UnityEngine;
using System.Collections;

/// <summary>
/// Defines a component that represents a rule in the game.
/// This is the base class for all game rules.
/// </summary>
public abstract class GameRule : MonoBehaviour
{
    public abstract void Apply(RuleData data);
}
