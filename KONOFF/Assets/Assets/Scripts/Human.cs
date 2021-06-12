using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.Humans += 1;
        Destroy(gameObject);
    }
}
