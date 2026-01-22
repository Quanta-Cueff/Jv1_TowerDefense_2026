using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class HpManager : MonoBehaviour
{

    public int currentHP;
    public int maxHP;
    public List<GameObject> mobse;



    private void Start()
    {
        currentHP = maxHP;
    }

    public void RemoveHp(int pvPerdu)
    {
        currentHP -= pvPerdu;
        if(currentHP <= 0)
        {
            Die();
        }
    }
    

    public void Die()
    {
        if (mobse != null)
        {
            var mob = Instantiate(mobse[Random.Range(0,mobse.Count)]);
           
        }
        Destroy(gameObject);
        

    }
}
