using UnityEngine;
using System.Collections;
using Gamelogic.Grids2;

public class SnapToGridOnStart : MonoBehaviour
{
    [SerializeField]
    protected HexGrid Grid;
    protected Transform Trans;

    /// <summary>
    /// Whether the tile should be added to the grid on start.
    /// </summary>
    public bool PlaceInGrid = false;

    // Use this for initialization
    protected virtual void Start()
    {
        Grid = Grid ?? FindObjectOfType<HexGrid>();
        Trans = transform;
        var pos = FindCurrentGridPosition();
        SnapToGridPosition(pos);
        if (PlaceInGrid && Grid.Grid[pos] == null)
        {
            Grid.Grid[pos] = GetComponent<TileCell>();
        }
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
