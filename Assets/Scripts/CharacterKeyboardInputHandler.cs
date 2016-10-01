using UnityEngine;
using System.Collections;

public class CharacterKeyboardInputHandler : MonoBehaviour
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
            Character.MoveNorthEast();
        }
        else if (ShouldMoveNorth())
        {
            Character.MoveNorth();
        }
        else if (ShouldMoveNorthWest())
        {
            Character.MoveNorthWest();
        }
        else if (ShouldMoveSouthWest())
        {
            Character.MoveSouthWest();
        }
        else if (ShouldMoveSouth())
        {
            Character.MoveSouth();
        }
        else if (ShouldMoveSouthEast())
        {
            Character.MoveSouthEast();
        }
        else if (ShouldMoveSouthWest())
        {
            Character.MoveSouthWest();
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
}
