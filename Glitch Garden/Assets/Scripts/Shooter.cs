using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] Transform gun;

    public void Fire(){
        Instantiate(projectile, gun.position, Quaternion.identity);
    }

}
