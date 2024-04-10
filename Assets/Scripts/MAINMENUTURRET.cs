using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAINMENUTURRET : MonoBehaviour
{
    public float shootRate = 1f;
    public GameObject bullet;
    public Transform firePoint;

    private void Start()
    {
        InvokeRepeating("Shoot", shootRate, shootRate);
    }

    private void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
