using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public GameObject stats;
    public GameObject doWylaczenia;

    public Text note1;
    public Text note2;
    public Text note3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        stats.SetActive(true);
        doWylaczenia.SetActive(false);

        note1.text = GameManager.instance.Humans.ToString() + " people saved";
        note2.text = GameManager.instance.KilledEnemies.ToString() + " enemies defated";
        note3.text = "Gratulujemy Zwyciêstwa, Dzikie Wiep¿e!";
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        stats.SetActive(false);
        doWylaczenia.SetActive(true);
    }
}
