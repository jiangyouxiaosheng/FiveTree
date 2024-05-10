using System.Collections.Generic;
using UnityEngine;
namespace ObjectPool
{
    public class GameObjectGroup : MonoBehaviour
    {
        /// <summary>
        ///δʹ�õ���Դ���� 
        /// </summary>
        public List<PoolObject> pool;
        /// <summary>
        /// ʹ���˵Ķ���
        /// </summary>
        public List<PoolObject> usePool;
        private GameObject Go;
        /// <summary>
        /// ���������
        /// </summary>
        //public bool DontDestory;
        /// <summary>
        /// ����
        /// </summary>
        private int capcity;
        public void Init(string name, GameObject prefab, int size, GameObject parent)
        {
            capcity = size;
            pool = new List<PoolObject>(capcity * 2);
            Go = prefab;
            usePool = new List<PoolObject>(capcity * 2);
            for (int i = 0; i < capcity; i++)
            {
                GameObject a = Instantiate(prefab, Vector3.zero, Quaternion.identity);
                a.transform.parent = parent.transform;
                a.GetComponent<PoolObject>().group = this;
                a.SetActive(false);
                PoolObject b = a.GetComponent<PoolObject>();
                b.Init();
                pool.Add(b);
            }
        }
        /// <summary>
        /// ȡһ������
        /// </summary>
        public PoolObject GetGameobject(Vector3 position, Quaternion rotation)
        {
            if (pool.Count == 0)
            {
                AddObject();
            }
            var temp = pool[0];
            pool.RemoveAt(0);
            usePool.Add(temp);


            temp.gameObject.transform.SetPositionAndRotation(position, rotation);
            temp.gameObject.SetActive(true);
            temp.Push();
            return temp;
        }
        /// <summary>
        /// ��������
        /// </summary>
        public void Restore()
        {
            PoolObject c = usePool[0];
            usePool.RemoveAt(0);
            c.gameObject.SetActive(false);
            c.Pull();
            pool.Add(c);
        }
        public void Restore(PoolObject go)
        {
            usePool.Remove(go);
            pool.Add(go);
            go.gameObject.SetActive(false);
            go.Pull();
        }
        /// <summary>
        /// ���ٶ����
        /// </summary>
        public void Destory()
        {

        }
        private void AddObject()
        {
            Debug.Log("���������");
            for (int i = 0; i < 5; i++)
            {
                GameObject a = Instantiate(Go, Vector3.zero, Quaternion.identity);
                a.SetActive(false);
                a.transform.SetParent(transform);
              //  a.transform.SetParent();
                PoolObject b = a.GetComponent<PoolObject>();
                pool.Add(b);
            }
            capcity += 5;
        }
    }
}