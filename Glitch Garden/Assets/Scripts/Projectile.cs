using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 8f;
    [SerializeField] int damage = 50;
    float destroyDelay = 5f;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        Destroy(gameObject, destroyDelay);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.GetComponent<Health>();
        var attacker = other.GetComponent<Attacker>();
        if (health && attacker)
        {
            health.DealDamage(damage);
            Destroy(gameObject);//destroying projectile after collision
        }

    }
}
