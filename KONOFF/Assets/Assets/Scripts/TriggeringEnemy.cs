using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeringEnemy : MonoBehaviour
{
    public GameObject enemy;
    private void Start()
    {
        enemy.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemy.SetActive(true);
    }
}

