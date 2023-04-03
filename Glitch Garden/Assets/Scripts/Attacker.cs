using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 2f)] float currentSpeed = 0.35f;

    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }
    public void SetMovementSpeed(float speed){
        currentSpeed = speed;
    }
}
