using Player;
using UnityEngine;

public abstract class ModuleSingleton<T> : MonoBehaviour where T : MonoBehaviour, IModule
{
    private static T _instance;
    public static T Instance//ÿ��ע���ģ���ʵ��
    {
        get
        {
            if (_instance == null)
                throw new System.Exception("������ʵ��" + typeof(T));
            return _instance;
        }
    }
    public ModuleSingleton()
    {
        if (_instance != null)
        {
            throw new System.Exception("�Ѿ�����ʵ��");
        }
        _instance = this as T;
        
    }
    
}