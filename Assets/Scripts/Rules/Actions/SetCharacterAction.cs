using UnityEngine;
using System.Collections;

/// <summary>
/// Defines an action that is able to register the player contained in the rule data as the current character.
/// </summary>
public class SetCharacterAction : RuleAction
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public override bool Apply(RuleData data)
    {
        gameManager.CurrentCharacter = data.Character;
        return true;
    }
}
