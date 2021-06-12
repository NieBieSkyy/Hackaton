using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public  float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;

    private void Start()
    {
        Invoke("DestroyBullet", lifeTime);
    }
    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
            }
            DestroyBullet();
        }


        transform.Translate(transform.right * speed * Time.deltaTime);
    }
    void DestroyBullet()
    {
        Destroy(gameObject);    
    }
}
