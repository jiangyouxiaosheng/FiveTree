using ObjectPool;
using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackManager : ModuleSingleton<PlayerAttackManager>, IModule
{
    public List<GameObject> playerSkills = new List<GameObject>();

    private Vector2 mouseDir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
     
    

        playerSkills[0].GetComponent<SkillData>().timer-=Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.J))
        {
            NormalAttackCD();
        }
    }
    private void FixedUpdate()
    {
        
    }

    void NormalAttackCD()
    {

        if (playerSkills[0].GetComponent<SkillData>().timer <= 0)
        {
            playerSkills[0].GetComponent<SkillData>().UsedSkill();
           PoolManager.Instance.GetGameObjectToPool<NormalAttack>("PlayerNormalAttack", PlayerAttribute.Instance.palyerAttackPoint.position, Quaternion.identity);
           
        }
     

    }
 

   

    public void OnCreate(object createParam)
    {

    }

    public void OnUpdate()
    {

    }
}
