using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public void EatDot(HexPlayer player, Collider2D dot)
    {
        if (dot.CompareTag("dot"))
        {
            player.Score += 10;
            DestroyObject(dot.gameObject);
        }
    }

    public void EatSuperDot(HexPlayer player, Collider2D dot)
    {
        if (dot.CompareTag("super-dot"))
        {
            player.BecomeSupered();
            DestroyObject(dot.gameObject);
        }
    }

    public void SendPlayerCollision(HexPlayer player, Collider2D other)
    {
        EatDot(player, other);
        EatSuperDot(player, other);
    }
}
