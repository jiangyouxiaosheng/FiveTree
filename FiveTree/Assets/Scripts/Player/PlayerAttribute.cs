using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Player
{
    /// <summary>
    /// ��һ�������
    /// </summary>
    public class PlayerAttribute : ModuleSingleton<PlayerAttribute>, IModule
    {
        [Header("��һ�������")]
        public int playerLv;
        public int playerExp;
        public int playerHp;  
        public int playerHpMax;
        public int playerMp;
        public int playerMpMax;
        public int playerAtk;
        public int playerDef;
        public float playerMoveSpeed;
        public float playerAttackSpeed;

        [Header("��ұ�������")]
        public int playerCoins; //��ҽ��
        //public List<PlayerItem> playerItems = new List<PlayerItem>();   //��ұ���











        public void OnCreate(object createParam)
        {
            throw new System.NotImplementedException();
        }

        public void OnUpdate()
        {
            throw new System.NotImplementedException();
        }
    }

}
