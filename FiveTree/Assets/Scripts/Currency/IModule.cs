public interface IModule
{
    /// <summary>
    /// ����ģ��
    /// </summary>
    void OnCreate(System.Object createParam);

    /// <summary>
    /// ��ѯģ��
    /// </summary>
    void OnUpdate();
}