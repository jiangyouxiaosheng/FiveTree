using ObjectPool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NormalAttack : PoolObject
{
    private SkillData skillData;

    private void Start()
    {
        skillData = GetComponent<SkillData>();
    }
    private void Update()
    {
      transform.Translate(Vector2.right * Time.deltaTime * skillData.playerAttackBase.skillSpeed);
    }

    private void OnDestroy()
    {
        
    }


}
