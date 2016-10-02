using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public List<GameRule> Rules = new List<GameRule>();

    public void ApplyTrigger(Player player, GameObject collider)
    {
        var data = new RuleData()
        {
            Player = player,
            Collider = collider
        };
        foreach (var rule in Rules)
        {
            rule.Apply(data);
        }
    }
}
