using System.Collections.Generic;
using UnityEngine;

namespace ObjectPool
{
    public class PoolManager : ModuleSingleton<PoolManager>, IModule
    {
        private Dictionary<string, GameObjectGroup> PoolMap = new Dictionary<string, GameObjectGroup>();
        public PoolInfo[] PoolInfo;
        private GameObject root;
        public void OnCreate(object createParam)
        {
            root = new GameObject("[Pool]");
            root.transform.position = Vector3.zero;
            UnityEngine.GameObject.DontDestroyOnLoad(root);
        }
        public void OnUpdate()
        {

        }
        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="name">�����</param>
        /// <param name="capcity">����Ŀռ�</param>
        /// <returns></returns>
        public void CreatePool(PoolInfo info, bool destory = true)
        {
            if (PoolMap.ContainsKey(info.name))
            {
                Debug.LogError(info.name + "�Ѿ�����");
                return;
            }
         
            var group = new GameObject(info.name);
            var c = group.AddComponent<GameObjectGroup>();
            c.Init(info.name, info.prefab, info.size, group);   
            PoolMap[info.name] = c;
            if (!destory)
            {
                Object.DontDestroyOnLoad(group);
            }
        }
        public GameObjectGroup GetPool(string name)
        {
            if (PoolMap.ContainsKey(name))
                return PoolMap[name];
            else
                Debug.LogError(name + "������");
            return null;

        }
        /// <summary>
        /// �ӳ����л��һ������
        /// </summary>
        /// <param name="Poolname">��������</param>
        /// <param name="position">��������</param>
        /// <param name="rotation">��ת�Ƕ�</param>
        /// <returns></returns>
        public T GetGameObjectToPool<T>(string Poolname, Vector3 position, Quaternion rotation) where T : PoolObject
        {
            if (PoolMap.ContainsKey(Poolname))
            {
                PoolObject Go = PoolMap[Poolname].GetGameobject(position, rotation);
                return Go as T;
            }
            Debug.LogError("����ز�����");
            return null;
        }
        //���մ���ʱ��������巵�س���
        public void ReturnObjectToPool(string name)
        {
            PoolMap[name].Restore();
        }

        public void ReturnObjectToPool(string name, PoolObject go)
        {
            PoolMap[name].Restore(go);
        }
    }
    public class PoolInfo
    {
        public PoolInfo(string name, int size, GameObject prefab)
        {
            this.prefab = prefab;
            this.size = size;
            this.name = name;
        }

        public PoolInfo()
        {
        }

        public string name;
        public int size;
        public GameObject prefab;
    }
}