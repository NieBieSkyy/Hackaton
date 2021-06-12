using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int Keys;
    public int PenDrives;
    public int Humans;
    public int KilledEnemies;

    public Text KeyNumber;
    public Text PenDriveNumber;
    public Text HumanNumber;

    public GameObject EndGame;
    public GameObject LastButton;

    public Animator finalHatch;

    void Start()
    {
        instance = this;
        EndGame.SetActive(false);
        LastButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        KeyNumber.text = Keys.ToString();
        PenDriveNumber.text = PenDrives.ToString() + " / 5";
        HumanNumber.text = Humans.ToString() + " / 10";

        if (PenDrives == 4)
        {
            finalHatch.SetBool("open", true);
        }
    }
}
