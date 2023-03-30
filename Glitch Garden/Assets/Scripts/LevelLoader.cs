using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float loadDelay = 4f;
    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(DelayOnLodingGame());
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    IEnumerator DelayOnLodingGame()
    {
        yield return new WaitForSeconds(loadDelay);
        LoadNextScene();
    }

    public void QuitGame()
    {
        Debug.Log("quitting...");
        Application.Quit();
    }
}
