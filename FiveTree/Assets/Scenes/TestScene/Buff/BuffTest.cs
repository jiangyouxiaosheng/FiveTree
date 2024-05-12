using Fight;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffTest : MonoBehaviour
{

    [SerializeField]
    CombatEntity entity;
    void Start()
    {
        //给自己添加了一个扣血buff，buff创建者也是自己
        entity.buffManager.AddBuff("poisoned",entity);
    }

    void Update()
    {
        
    }
}
