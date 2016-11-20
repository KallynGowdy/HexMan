using UnityEngine;
using System.Collections;
using System.Linq;

public class OrCondition : RuleAction
{
    public RuleAction[] Conditions = new RuleAction[0];

    public override bool Apply(RuleData data)
    {
        return Conditions.Any(c => c.Apply(data));
    }
}
