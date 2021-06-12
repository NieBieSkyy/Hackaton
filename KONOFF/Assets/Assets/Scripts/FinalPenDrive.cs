using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPenDrive : MonoBehaviour
{
    public GameObject LastButton;
    public GameObject NapisDoUsuniecia;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LastButton.SetActive(true);
        NapisDoUsuniecia.SetActive(false);
        GameManager.instance.PenDrives += 1;
        Destroy(gameObject);
    }
    private void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0), 1);
    }
}
