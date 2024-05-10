using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttackBase 
{
    [Header("���ܻ�������")]
    private PlayerAttackEnum attackEnum = PlayerAttackEnum.None;//����
    private string skillName = "";//����
    private int skillDamege = 0;//�˺�
    private float skillCD = 0;//����CD
    private int skillNeedConsume = 0;//����
    private float skillNeedTime = 0;//ӽ������ʱ��
    private bool isNeedTarget;//�Ƿ�Ϊָ��Ŀ��
    private string skillForTarget = "";//Ŀ��


  




    [Header("����UI���")]
    [SerializeField]
    private Image skillImage;//����ͼ��
    [SerializeField]
    private string skillIntroduce="";//���ܼ��


    /// <summary>
    /// ��������
    /// </summary>
    public PlayerAttackEnum PlayerAttackEnum
    {
        get { return attackEnum; }
        protected set { attackEnum = value; }
    }
    /// <summary>
    /// ��������
    /// </summary>
    public string SkillName
    {
        get { return skillName; }
        protected set { skillName = value; }
    }
    /// <summary>
    /// �����˺�
    /// </summary>
    public int SkillDamege
    {
        get { return skillDamege; }
        protected set { skillDamege = Math.Clamp(value,0,int.MaxValue);}
    }
    /// <summary>
    /// ����CD
    /// </summary>
    public float SkillCD
    {
        get { return skillCD; }
        protected set { skillCD = Math.Clamp(value, 0, float.MaxValue); }
    }
    /// <summary>
    /// ��������
    /// </summary>
    public int SkillNeedConsume
    {
        get { return skillNeedConsume; }
        protected set { skillNeedConsume = Math.Clamp(value, 0, int.MaxValue); }
    }
    /// <summary>
    /// ����ӽ������ʱ��
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
