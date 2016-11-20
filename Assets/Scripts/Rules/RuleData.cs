using UnityEngine;
using System.Collections;

public class RuleData
{

    public Player Player
    {
        get { return Character.GetComponent<Player>(); }
    }

    public bool DidWin;

    public Character Character;
    public GameObject Collider;
}
