using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Character))]
public class Teleportable : MonoBehaviour
{
    private Character character;
    private bool teleporting = false;
    private Teleport originalTeleport = null;

    void Start()
    {
        character = GetComponent<Character>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        var teleport = other.GetComponent<Teleport>();
        if (teleport != null && !teleporting)
        {
            originalTeleport = teleport;
            teleport.RequestTeleport(character);
            teleporting = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        var teleport = other.GetComponent<Teleport>();
        if (teleport != null && originalTeleport != teleport)
        {
            originalTeleport = null;
            teleporting = false;
        }
    }

    void Update()
    {
        if (teleporting)
        {
            character.RequestKeepDirectionForFrame();
        }
    }
}
