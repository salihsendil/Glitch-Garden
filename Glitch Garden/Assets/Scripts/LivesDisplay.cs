using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int lives = 1;
    [SerializeField] int  damage = 1;
    Text livesText;

    LevelLoader levelLoader;

    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void TakeLife()
    {
        lives -= damage;
        UpdateDisplay();

        if(lives<=0){
            FindObjectOfType<LevelLoader>().LoadGameOverScene();
        }
    }
}
