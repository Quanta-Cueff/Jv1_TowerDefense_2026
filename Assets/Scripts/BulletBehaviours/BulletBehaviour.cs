using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class BulletBehaviour : MonoBehaviour
{
    public EnemyContainer targetEnemy;
    public float speed = 0.2f;
    public int dammage;
    public SpriteRenderer spriteRenderer;
    private int rng;

    void Start()
    {
        rng = Random.Range(1, 100);
        dammage = (100 / rng);
        transform.localScale = new Vector3(Mathf.Sqrt(dammage)/3,Mathf.Sqrt(dammage)/3, 1);
        spriteRenderer.color = new Color((80 - (rng * 1.25f))* 0.025f, (rng+20)*0.025f, 0);
        print(rng);
    }
    void Update()
    {
        if (targetEnemy == null)
        {
               Destroy(gameObject);
        }
        transform.position = Vector3.MoveTowards(transform.position, targetEnemy.transform.position, speed);    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyContainer collisionEnemyComponent = collision.gameObject.GetComponent<EnemyContainer>();

        if (collisionEnemyComponent != null)
        {

            collisionEnemyComponent.myHpManager.RemoveHp(dammage);
            Destroy(gameObject);
        }
    }
}
