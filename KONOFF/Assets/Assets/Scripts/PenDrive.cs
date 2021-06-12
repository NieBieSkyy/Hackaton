using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenDrive : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.PenDrives += 1;
        Destroy(gameObject);
    }
}
