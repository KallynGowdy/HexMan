using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// The root action that is used to handle game rules.
    /// </summary>
    public RuleAction RootRule;

    /// <summary>
    /// The character that the player has selected to use.
    /// </summary>
    public Character CurrentCharacter;

    public void ApplyTrigger(Character player, GameObject collider)
    {
        var data = new RuleData()
        {
            Character = player,
            Collider = collider
        };
        RootRule.Apply(data);
    }
}
