using UnityEngine;
using System.Collections;
using Gamelogic.Grids2;
using UnityEditor;
using UnityEngine.SceneManagement;

/// <summary>
/// Defines an action that is able to load a new game level.
/// </summary>
public class LoadLevelAction : RuleAction
{
    public string SceneName;
    public GameObject World;
    public GameObject LoadingScreen;
    private GameManager gameManager;
    private Scene newScene;
    private Scene currentScene;
    private bool loadingScene;
    private AsyncOperation op;
    private Character currentPlayer;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public override bool Apply(RuleData data)
    {
        loadingScene = true;
        currentPlayer = gameManager.CurrentCharacter;
        currentPlayer.transform.SetParent(null, true);
        DestroyObject(World);
        Instantiate(LoadingScreen);
        currentScene = SceneManager.GetActiveScene();
        op = SceneManager.LoadSceneAsync(SceneName, LoadSceneMode.Additive);
        return true;
    }

    void Update()
    {
        if (loadingScene && op.isDone)
        {
            newScene = SceneManager.GetSceneByName(SceneName);
            SceneManager.MoveGameObjectToScene(currentPlayer.gameObject, newScene);
            if (SceneManager.SetActiveScene(newScene) && SceneManager.UnloadScene(currentScene))
            {
                var newGameManager = FindObjectOfType<GameManager>();
                var newParent = newGameManager.CurrentCharacter.transform.parent;
                var newRot = newGameManager.CurrentCharacter.transform.rotation;
                var newGridPos = newGameManager.CurrentCharacter.CurrentGridPosition;
                DestroyObject(newGameManager.CurrentCharacter.gameObject);
                newGameManager.CurrentCharacter = currentPlayer;
                currentPlayer.transform.SetParent(newParent);
                currentPlayer.transform.rotation = newRot;
                currentPlayer.CurrentGridPosition = newGridPos;
                currentPlayer.SnapToGridPosition(newGridPos);
                currentPlayer.SetDirection(GridPoint2.Zero);
                var trigger = currentPlayer.GetComponent<CharacterColliderTrigger>();
                if (trigger != null)
                {
                    trigger.GameManager = newGameManager;
                }
            }
            loadingScene = false;
        }
    }
}
