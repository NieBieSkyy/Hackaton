using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notatki : MonoBehaviour
{
    public GameObject notatka;
    public GameObject notatnik;

    private void Start()
    {
        notatka.SetActive(false);
        notatnik.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        notatka.SetActive(true);
        notatnik.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        notatka.SetActive(false);
        notatnik.SetActive(false);
    }
}
