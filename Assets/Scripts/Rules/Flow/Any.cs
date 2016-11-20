using UnityEngine;
using System.Collections;
using System.Linq;

public class Any : FlowAction
{
    public override bool Apply(RuleData data)
    {
        return Actions.Any(a => a.Apply(data));
    }
}
