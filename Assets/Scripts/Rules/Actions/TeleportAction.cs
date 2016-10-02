using UnityEngine;
using System.Collections;

/// <summary>
/// Defines a rule action that is able to teleport a character from one cell to another.
/// </summary>
public class TeleportAction : RuleAction
{
    public Transform First;
    public Transform Second;
    public HexGrid Grid;

    private bool attempted = false;
    private bool applied = false;

    void Start()
    {
        Grid = Grid ?? FindObjectOfType<HexGrid>();
    }

    public override void Apply(RuleData data)
    {
        if (!applied)
        {
            if (data.Collider.transform == First)
            {
                TeleportTo(data.Character, Second);
            }
            else
            {
                TeleportTo(data.Character, First);
            }
            applied = true;
        }
        attempted = true;
    }

    void Update()
    {
        if (applied && !attempted)
        {
            applied = false;
        }
        attempted = false;
    }

    private void TeleportTo(Character character, Transform target)
    {
        var targetGridPos = Grid.GridMap.WorldToGridToDiscrete(target.position);
        character.CurrentGridPosition = targetGridPos;
        character.SnapToGridPosition(targetGridPos);
    }
}
