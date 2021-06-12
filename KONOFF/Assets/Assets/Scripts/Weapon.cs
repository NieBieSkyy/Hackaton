using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    private void Start()
    {
    }
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(bullet, firePoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

    }
}
