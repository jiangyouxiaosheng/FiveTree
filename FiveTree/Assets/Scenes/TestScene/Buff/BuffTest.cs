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
        //���Լ������һ����Ѫbuff��buff������Ҳ���Լ�
        entity.buffManager.AddBuff("poisoned",entity);
    }

    void Update()
    {
        
    }
}
