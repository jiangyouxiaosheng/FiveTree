using UnityEngine;
namespace ObjectPool
{
    /// <summary>
    /// 用的时候给要生成的预制体创建一个继承此物体的脚本
    /// </summary>

    public class PoolObject : MonoBehaviour
    {
        public GameObjectGroup group;
        /// <summary>
        /// 添加进池子的时候调用一次
        /// </summary>
        public virtual void Init()
        {

        }

        /// <summary>
        /// 出队时候调用
        /// </summary>
        public virtual void Push()
        {

        }
        /// <summary>
        /// 回收时候调用
        /// </summary>
        public virtual void Pull()
        {

        }
    }
}