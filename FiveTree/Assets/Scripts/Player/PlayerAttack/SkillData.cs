using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillData : MonoBehaviour
{
    public PlayerAttackBase playerAttackBase;
    public float timer;
    private void Start()
    {
        timer = playerAttackBase.skillCD;
    }

    public void UsedSkill()
    {
        timer = playerAttackBase.skillCD;
    }


}
