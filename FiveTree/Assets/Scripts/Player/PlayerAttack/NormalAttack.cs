using ObjectPool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NormalAttack : PoolObject
{
    public PlayerAttackBase attack;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (attack.skillCD > 0)
        {
            attack.skillCD -= Time.deltaTime;
        }



        Debug.LogError(attack.skillCD);
      transform.Translate(Vector2.right * Time.deltaTime * attack.skillSpeed);
    }

    private void OnDestroy()
    {
        
    }


}
