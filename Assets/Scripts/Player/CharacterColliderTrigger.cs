using UnityEngine;
using System.Collections;

public class CharacterColliderTrigger : MonoBehaviour
{
    public Character Character;
    public GameManager GameManager;

    void Start()
    {
        GameManager = GameManager ?? FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.ApplyTrigger(Character, other.gameObject);
    }
}
