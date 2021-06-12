using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastButton : MonoBehaviour
{
    public GameObject LastDoor;
    public GameObject Arrows;
    public GameObject Button;
    public GameObject serverExplode;
    public GameObject serverExploding;

    public Animator movingPlatform;
    public Animator buttonPressing;
    
    private void Start()
    {
        Arrows.SetActive(false);    
        LastDoor.SetActive(true);
        serverExplode.SetActive(false);
        serverExploding.SetActive(true);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(pressing());
        
    }


    IEnumerator pressing()
    {
        buttonPressing.SetBool("open", true);
        yield return new WaitForSeconds(1.5f);
        serverExplode.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        serverExploding.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        Arrows.SetActive(true);
        LastDoor.SetActive(false);
        Button.SetActive(false);
        movingPlatform.SetBool("move", true);

    }
}