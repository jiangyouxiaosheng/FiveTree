using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Player
{
    /// <summary>
    /// 玩家基础属性
    /// </summary>
    public class PlayerAttribute : ModuleSingleton<PlayerAttribute>, IModule
    {
        [Header("玩家基础属性")]
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

        [Header("玩家背包属性")]
        public int playerCoins; //玩家金币
        //public List<PlayerItem> playerItems = new List<PlayerItem>();   //玩家背包











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
