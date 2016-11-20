using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public RuleAction RootRule;

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
