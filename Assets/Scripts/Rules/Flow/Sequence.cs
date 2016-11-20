using UnityEngine;
using System.Collections;
using System.Linq;

public class Sequence : FlowAction
{
    public override bool Apply(RuleData data)
    {
        return Actions.All(a => a.Apply(data));
    }
}
