using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject Key;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.Keys++;
        DestroyKey();
    }
    void DestroyKey()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0), 1);
    }
}
