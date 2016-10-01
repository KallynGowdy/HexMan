using UnityEngine;
using System.Collections;
using Gamelogic.Grids2;
using Gamelogic.Grids2.Graph;
using GridPoint2 = Gamelogic.Grids2.GridPoint2;

public class Character : MonoBehaviour
{
    public GridPoint2 CurrentGridPosition;
    public GridPoint2 NextGridPosition;
    public GridPoint2 CurrentAttemptedDirection;
    public float Speed = 1;

    private HexGrid grid;

    void Start()
    {
        grid = FindObjectOfType<HexGrid>();
        CurrentGridPosition = FindCurrentGridPosition();
        NextGridPosition = CurrentGridPosition;
        Debug.Log(CurrentGridPosition);
    }

    private GridPoint2 FindCurrentGridPosition()
    {
        return grid.GridMap.WorldToGridToDiscrete(transform.position);
    }

    void Update()
    {
        UpdateNextGridPosition();
        Move();
        UpdateCurrentGridPosition();
    }

    private void UpdateCurrentGridPosition()
    {
        CurrentGridPosition = FindCurrentGridPosition();
    }

    private void Move()
    {
        var nextWorldPos = FindNextWorldPosition();
        Vector3 dir = GetNextMovementDirection(nextWorldPos);
        UpdatePosition(dir);
        UpdateRotation(dir);
    }

    private void UpdateRotation(Vector3 dir)
    {
        if (NotTooClose(dir))
        {
            dir = dir.normalized;
            var angleRad = Mathf.Atan2(dir.y, dir.x);
            var angle = angleRad * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, angle);
        }
    }

    private void UpdateNextGridPosition()
    {
        var nextGridPosition = CurrentGridPosition.Add(CurrentAttemptedDirection);
        if (CheckValidMovePos(nextGridPosition))
        {
            NextGridPosition = nextGridPosition;
        }
    }

    private void UpdatePosition(Vector3 dir)
    {
        if (NotTooClose(dir))
        {
            transform.position += dir.normalized * Speed * Time.deltaTime;
        }
    }

    private static bool NotTooClose(Vector3 dir)
    {
        return Mathf.Abs(dir.magnitude) > 0.1;
    }

    private Vector2 GetNextMovementDirection(Vector3 nextWorldPos)
    {
        return (Vector2)(nextWorldPos - transform.position);
    }

    private Vector3 FindNextWorldPosition()
    {
        return grid.GridMap.GridToWorld(NextGridPosition);
    }

    private bool GridPositionIsOpen(GridPoint2 nextGridPosition)
    {
        return grid.Grid[nextGridPosition] == null;
    }

    public void MoveNorthEast()
    {
        SetDirection(HexGrid.NorthEast);
    }

    public void MoveNorthWest()
    {
        SetDirection(HexGrid.NorthWest);
    }

    public void MoveNorth()
    {
        SetDirection(HexGrid.North);
    }

    public void MoveSouthEast()
    {
        SetDirection(HexGrid.SouthEast);
    }

    public void MoveSouthWest()
    {
        SetDirection(HexGrid.SouthWest);
    }

    public void MoveSouth()
    {
        SetDirection(HexGrid.South);
    }

    private void SetDirection(GridPoint2 nextDirection)
    {
        CurrentAttemptedDirection = nextDirection;
    }

    public bool CheckValidMovePos(GridPoint2 nextGridPosition)
    {
        return GridPositionIsOpen(nextGridPosition);
    }

}
