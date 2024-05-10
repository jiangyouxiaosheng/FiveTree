using UnityEngine;
namespace ObjectPool
{
    /// <summary>
    /// �õ�ʱ���Ҫ���ɵ�Ԥ���崴��һ���̳д�����Ľű�
    /// </summary>

    public class PoolObject : MonoBehaviour
    {
        public GameObjectGroup group;
        /// <summary>
        /// ��ӽ����ӵ�ʱ�����һ��
        /// </summary>
        public virtual void Init()
        {

        }

        /// <summary>
        /// ����ʱ�����
        /// </summary>
        public virtual void Push()
        {

        }
        /// <summary>
        /// ����ʱ�����
        /// </summary>
        public virtual void Pull()
        {

        }
    }
}