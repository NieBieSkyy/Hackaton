using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    public GameObject deathEffect;

    public Animator animator;

    private void Update()
    {
        if (health <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            GameManager.instance.KilledEnemies++;
            Destroy(gameObject);
        }
        
    }

    public void TakeDamage(int damage)
    {

        StartCoroutine(hit(damage));

    }

    IEnumerator hit(int damage)
    {
        animator.Play("dostawaniePoRyj");
        health -= damage;
        yield return new WaitForSeconds(0.5f);
        animator.Play("Idle");



    }
}
