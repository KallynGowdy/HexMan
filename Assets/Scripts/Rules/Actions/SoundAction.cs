using UnityEngine;
using System.Collections;

/// <summary>
/// Defines an action that plays a sound clip.
/// </summary>
public class SoundAction : RuleAction
{
    public AudioSource Source;

    void Start()
    {
        Source = Source ?? GetComponent<AudioSource>();
    }

    public override bool Apply(RuleData data)
    {
        Source.Play();
        return true;
    }
}
