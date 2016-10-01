using UnityEngine;
using System.Collections;
using Gamelogic.Grids;
using Gamelogic.Grids2;
using GridPoint2 = Gamelogic.Grids2.GridPoint2;
using TileCell = Gamelogic.Grids2.TileCell;

public class HexGrid : GridBehaviour<GridPoint2, TileCell>
{
    private static readonly GridPoint2 West = new GridPoint2(-1, 0);
    private static readonly GridPoint2 East = new GridPoint2( 1, 0);

    public static readonly GridPoint2 North = new GridPoint2(0, 1);
    public static readonly GridPoint2 NorthEast = East + North;
    public static readonly GridPoint2 NorthWest = West + North;

    public static readonly GridPoint2 South = new GridPoint2(0, -1);
    public static readonly GridPoint2 SouthEast = East + South;
    public static readonly GridPoint2 SouthWest = West;
}
