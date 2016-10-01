using UnityEngine;
using System.Collections;
using Gamelogic.Grids2;

public class SnapToGridOnStart : MonoBehaviour
{
    [SerializeField]
    protected HexGrid Grid;
    protected Transform Trans;

    // Use this for initialization
    protected virtual void Start()
    {
        Grid = FindObjectOfType<HexGrid>();
        Trans = transform;
        var pos = FindCurrentGridPosition();
        SnapToGridPosition(pos);
    }

    protected GridPoint2 FindCurrentGridPosition()
    {
        return Grid.GridMap.WorldToGridToDiscrete(Trans.position);
    }

    public void SnapToGridPosition(GridPoint2 position)
    {
        Trans.position = Grid.GridMap.GridToWorld(position);
    }
}
