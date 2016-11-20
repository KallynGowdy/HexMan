using UnityEngine;
using System.Collections;
using System.Linq;

public class CheckWinCondition : RuleAction
{
    public override bool Apply(RuleData data)
    {
        return data.DidWin;
    }
}
