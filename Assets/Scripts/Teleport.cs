using UnityEngine;
using System.Collections;
using Gamelogic.Grids2;

public class Teleport : MonoBehaviour
{
    public Teleport Other;
    public HexGrid Grid;
    public AudioSource TeleportSound;

    private Transform Trans;

    public void Start()
    {
        Grid = Grid ?? FindObjectOfType<HexGrid>();
        Trans = transform;
    }

    public void RequestTeleport(Character character)
    {
        TeleportTo(character, Other);
    }

    private void TeleportTo(Character character, Teleport other)
    {
        var targetGridPos = Grid.GridMap.WorldToGridToDiscrete(other.Trans.position);
        character.CurrentGridPosition = targetGridPos;
        character.SnapToGridPosition(targetGridPos);
        TeleportSound.Play();
    }
}
