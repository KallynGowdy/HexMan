using UnityEngine;
using System.Collections;
using System.Linq;
using Gamelogic.Grids2;
using Gamelogic.Grids2.Graph;
using GridPoint2 = Gamelogic.Grids2.GridPoint2;

public class Character : SnapToGridOnStart
{
    public GridPoint2 CurrentGridPosition { get; set; }
    public GridPoint2 NextGridPosition { get; set; }
    public GridPoint2 CurrentAttemptedDirection { get; set; }
    public float Speed = 1;

    /// <summary>
    /// The list of tiles that the character can walk on.
    /// </summary>
    public string[] AllowedTileTags = new string[0];

    protected override void Start()
    {
        base.Start();
        CurrentGridPosition = FindCurrentGridPosition();
        NextGridPosition = CurrentGridPosition;
    }

    void Update()
    {
        Move();
    }
    
    private void Move()
    {
        Vector3 dir = Grid.GridMap.GridToWorld(CurrentAttemptedDirection); //GetNextMovementDirection(nextWorldPos);
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
            Trans.eulerAngles = new Vector3(Trans.eulerAngles.x, Trans.eulerAngles.y, angle);
        }
    }

    private void UpdatePosition(Vector3 dir)
    {
        if (NotTooClose(dir))
        {
            Trans.position += dir.normalized * Speed * Time.deltaTime;
        }
        else
        {
            SnapToGridPosition(CurrentGridPosition);
        }
    }

    private static bool NotTooClose(Vector3 dir)
    {
        return Mathf.Abs(dir.magnitude) > 0.05;
    }

    private Vector3 FindNextWorldPosition()
    {
        return Grid.GridMap.GridToWorld(NextGridPosition);
    }

    public void SetDirection(GridPoint2 nextDirection)
    {
        CurrentAttemptedDirection = nextDirection;
    }
}
