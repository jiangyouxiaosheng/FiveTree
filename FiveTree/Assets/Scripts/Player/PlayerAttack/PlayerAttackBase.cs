using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttackBase 
{
    [Header("技能基础数据")]
    private PlayerAttackEnum attackEnum = PlayerAttackEnum.None;//类型
    private string skillName = "";//名称
    private int skillDamege = 0;//伤害
    private float skillCD = 0;//技能CD
    private int skillNeedConsume = 0;//消耗
    private float skillNeedTime = 0;//咏唱所需时间
    private bool isNeedTarget;//是否为指定目标
    private string skillForTarget = "";//目标


  




    [Header("技能UI相关")]
    [SerializeField]
    private Image skillImage;//技能图标
    [SerializeField]
    private string skillIntroduce="";//技能简介


    /// <summary>
    /// 攻击类型
    /// </summary>
    public PlayerAttackEnum PlayerAttackEnum
    {
        get { return attackEnum; }
        protected set { attackEnum = value; }
    }
    /// <summary>
    /// 技能名称
    /// </summary>
    public string SkillName
    {
        get { return skillName; }
        protected set { skillName = value; }
    }
    /// <summary>
    /// 技能伤害
    /// </summary>
    public int SkillDamege
    {
        get { return skillDamege; }
        protected set { skillDamege = Math.Clamp(value,0,int.MaxValue);}
    }
    /// <summary>
    /// 技能CD
    /// </summary>
    public float SkillCD
    {
        get { return skillCD; }
        protected set { skillCD = Math.Clamp(value, 0, float.MaxValue); }
    }
    /// <summary>
    /// 技能消耗
    /// </summary>
    public int SkillNeedConsume
    {
        get { return skillNeedConsume; }
        protected set { skillNeedConsume = Math.Clamp(value, 0, int.MaxValue); }
    }
    /// <summary>
    /// 技能咏唱所需时间
    /// </summary>
    public float SkillNeedTime
    {
        get { return skillNeedTime; }
        protected set { skillNeedTime = Math.Clamp(value, 0, float.MaxValue); }
    }

    public bool IsNeedTarget
    {
        get { return isNeedTarget; }
        protected set { isNeedTarget = value; }
    }
    public string SkillForTarget
    {
        get { return skillForTarget; }
        protected set { skillForTarget = value; }
    }

    public virtual void OnStart() { }

    public virtual void FixedUpdate() { }

    public virtual void OnDestroy() { }

}
