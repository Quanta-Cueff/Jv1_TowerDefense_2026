using UnityEngine;

public class aléatoir_size : MonoBehaviour
{
    private BulletBehaviour bulletBehaviour;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletBehaviour.dammage = (100/Random.Range(1, 100));
        transform.localScale = new Vector3(bulletBehaviour.dammage / 10f, bulletBehaviour.dammage / 10f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
