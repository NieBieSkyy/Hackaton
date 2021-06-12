using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{
    public GameObject LockToOpen;
    public GameObject KeyNeeded;
    public GameObject doorToDestroy;
    

    public Animator animator = null;
    private void Start()
    {
        KeyNeeded.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(GameManager.instance.Keys > 0)
        {
            animator.SetBool("open", true);
            GameManager.instance.Keys -= 1;
            KeyNeeded.SetActive(false);
            DestroyLock();
            StartCoroutine(movableDestroyer());
        }
        else
        {
            KeyNeeded.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        KeyNeeded.SetActive(false);
    }
    void DestroyLock()
    {
        Destroy(gameObject);
    }
    IEnumerator movableDestroyer()
    {
        yield return new WaitForSeconds(10);
        Destroy(doorToDestroy);
    }
}
