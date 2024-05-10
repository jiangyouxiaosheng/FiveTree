using ObjectPool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackPool : MonoBehaviour
{
    public GameObject playerNormalAttack;
    // Start is called before the first frame update
    void Start()
    {
        PoolInfo poolInfo = new()
        {
            name = "PlayerNormalAttack",
            size = 10,
            prefab = playerNormalAttack
        };
        PoolManager.Instance.CreatePool(poolInfo);
    
    }

   
}
