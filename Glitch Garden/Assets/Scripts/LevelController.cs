using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    int numberOfAttacker = 0;
    bool levelTimerFinished = false;

    public void AttackerSpawned()
    {
        numberOfAttacker++;
    }
    public void AttackerKilled()
    {
        numberOfAttacker--;
        if (numberOfAttacker <= 0 && levelTimerFinished){
            Debug.Log("level ended");
        }
    }
    public void LevelTimerFinished(){
        levelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawnerArray){
            spawner.StopSpawning();
        }
    }
}

