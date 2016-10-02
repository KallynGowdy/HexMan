using UnityEngine;
using System.Collections;

public class PlayerColliderTrigger : MonoBehaviour
{
    public Player Player;
    public GameManager GameManager;

    void Start()
    {
        GameManager = GameManager ?? FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.ApplyTrigger(Player, other.gameObject);
    }
}
