using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Character))]
public class Player : MonoBehaviour
{
    public const string SuperTimeLeft = "SuperTimeLeft";

    public Character Character;
    public Animator Animator;
    
    public int Score = 0;

    void Start()
    {
        Character = Character ?? GetComponent<Character>();
        Animator = Animator ?? GetComponent<Animator>();
    }

    void Update()
    {
        UpdateSuperTimeLeft();
    }

    private void UpdateSuperTimeLeft()
    {
        var timeLeft = GetSuperTimeLeft();
        SetSuperTimeLeft(timeLeft - Time.deltaTime);
    }

    public bool IsSupered()
    {
        return GetSuperTimeLeft() > .1f;
    }

    private float GetSuperTimeLeft()
    {
        return Animator.GetFloat(SuperTimeLeft);
    }

    public void SetSuperTimeLeft(float timeLeft)
    {
        Animator.SetFloat(SuperTimeLeft, timeLeft);
    }
}
