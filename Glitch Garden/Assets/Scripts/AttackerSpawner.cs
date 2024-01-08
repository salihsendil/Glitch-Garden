using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] Attacker[] attackerPrefabArray;
    [SerializeField] float minSpawnTime = 1f;
    [SerializeField] float maxSpawnTime = 5f;
    [SerializeField] float delayToFirstSpawn = 20f;
    bool spawn = true;
    bool delayToSpawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            if (delayToSpawn)
            {
                yield return new WaitForSeconds(delayToFirstSpawn);
                delayToSpawn = false;
            }
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            SpawnAttacker();
        }
    }
    public void StopSpawning()
    {
        spawn = false;
        StopCoroutine(Start());
    }
    void Spawn(Attacker myAttacker)
    {
        Attacker newAttacker =
        Instantiate(myAttacker, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }
    void SpawnAttacker()
    {
        var attackerIndex = Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerIndex]);
    }
}