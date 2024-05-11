using ObjectPool;
using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NormalAttack : PoolObject
{
    private SkillData skillData;
    private Vector2 mouseDir;


  

    private void Start()
    {
        skillData = GetComponent<SkillData>();
        mouseDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        mouseDir.Normalize();
    }
    private void Update()
    {
       
        transform.position = mouseDir * Time.deltaTime*skillData.playerAttackBase.skillSpeed +(Vector2) transform.position;

    }

    private void OnDestroy()
    {
        
    }


}
