using UnityEngine;
using System.Collections;

public class HexKeyboardController : MonoBehaviour
{
    public Character Character;

    void Start()
    {
        Character = Character ?? GetComponent<Character>();
    }

    void Update()
    {
        if (ShouldMoveNorthEast())
        {
            MoveNorthEast();
        }
        else if (ShouldMoveNorth())
        {
            MoveNorth();
        }
        else if (ShouldMoveNorthWest())
        {
            MoveNorthWest();
        }
        else if (ShouldMoveSouthWest())
        {
            MoveSouthWest();
        }
        else if (ShouldMoveSouth())
        {
            MoveSouth();
        }
        else if (ShouldMoveSouthEast())
        {
            MoveSouthEast();
        }
        else if (ShouldMoveSouthWest())
        {
            MoveSouthWest();
        }
    }

    private static bool ShouldMoveNorthEast()
    {
        return Input.GetKey(KeyCode.E);
    }

    private static bool ShouldMoveNorthWest()
    {
        return Input.GetKey(KeyCode.Q);
    }

    private static bool ShouldMoveSouthWest()
    {
        return Input.GetKey(KeyCode.A);
    }

    private static bool ShouldMoveSouthEast()
    {
        return Input.GetKey(KeyCode.D);
    }

    private static bool ShouldMoveNorth()
    {
        return Input.GetKey(KeyCode.W);
    }

    private static bool ShouldMoveSouth()
    {
        return Input.GetKey(KeyCode.S);
    }

    public void MoveNorthEast()
    {
        Character.SetDirection(HexGrid.NorthEast);
    }

    public void MoveNorthWest()
    {
        Character.SetDirection(HexGrid.NorthWest);
    }

    public void MoveNorth()
    {
        Character.SetDirection(HexGrid.North);
    }

    public void MoveSouthEast()
    {
        Character.SetDirection(HexGrid.SouthEast);
    }

    public void MoveSouthWest()
    {
        Character.SetDirection(HexGrid.SouthWest);
    }

    public void MoveSouth()
    {
        Character.SetDirection(HexGrid.South);
    }
}
