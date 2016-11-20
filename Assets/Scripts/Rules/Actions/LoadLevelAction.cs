using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// Defines an action that is able to load a new game level.
/// </summary>
public class LoadLevelAction : RuleAction
{
    public string SceneName;
    public GameObject World;
    public GameObject LoadingScreen;

    public override bool Apply(RuleData data)
    {
        DestroyObject(World);
        Instantiate(LoadingScreen);
        SceneManager.LoadSceneAsync(SceneName);
        return true;
    }
}
