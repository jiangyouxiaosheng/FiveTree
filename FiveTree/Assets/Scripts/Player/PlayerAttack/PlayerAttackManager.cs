using ObjectPool;
using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackManager : ModuleSingleton<PlayerAttackManager>, IModule
{
    public List<PlayerAttackBase> playerSkills = new List<PlayerAttackBase>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)) 
        {
            NormalAttack();
        }
    }
    private void FixedUpdate()
    {
        
    }


    void NormalAttack()
    {
        if (playerSkills[0].skillCD <= 0)
        {
            PoolManager.Instance.GetGameObjectToPool<NormalAttack>("PlayerNormalAttack", PlayerAttribute.Instance.palyerAttackPoint.position, Quaternion.identity);
        }
      
    }
    //IEnumerator NormalAttackCD()
    //{
    //    yield return new w
    //}



    public void OnCreate(object createParam)
    {

    }

    public void OnUpdate()
    {

    }
}
