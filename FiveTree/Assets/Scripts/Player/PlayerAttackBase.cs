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
    private float skillNeedConsume = 0;//����
    private float skillNeedTime = 0;//ӽ������ʱ��
    private bool isNeedTarget;//�Ƿ�Ϊָ��Ŀ��
    private string skillForTarget = "";//Ŀ��


  




    [Header("����UI���")]
    [SerializeField]
    private Image skillImage;//����ͼ��
    [SerializeField]
    private string skillIntroduce="";//���ܼ��





}
