using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    Slider gameTimer;
    void Start()
    {
        gameTimer = FindObjectOfType<GameTimer>().GetComponent<Slider>();
    }

    void Update()
    {
        if(gameTimer.value==gameTimer.maxValue){
            var spawners = FindObjectsOfType<AttackerSpawner>();
            foreach(AttackerSpawner spawner in spawners){
                spawner.spawn = false;
            }
            Debug.Log("spawners stopped");
            var attackers = FindObjectsOfType<Attacker>();
            if(attackers.Length <= Mathf.Epsilon){
                Debug.Log("level end");
            }
        }
    }
}
