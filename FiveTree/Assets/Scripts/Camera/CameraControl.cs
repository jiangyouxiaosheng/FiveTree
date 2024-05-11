using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target; // �������Ҷ���
    public float smoothSpeed = 0.125f; // �����ƽ���̶�

    private void LateUpdate()
    {
        if (target != null)
        {
            // ����Ŀ��λ������Ļ�ϵ�����
            Vector3 targetPosition = Camera.main.WorldToViewportPoint(target.position);
            // ���������Ӧ���ƶ�������
            Vector3 delta = target.position - Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, targetPosition.z));//��ʾ��Ļ���ĵ����ӿ�����ϵ�е�λ�ã�����z���������Ŀ��λ������������ϵ�е�z�����꣬��֤��ͬһƽ���ϣ����������Ŀ����ͬһˮƽ���ϡ�Ҫ�����ͷ����0.5f�����֡�
            // �����������Ŀ��λ��
            Vector3 destination = transform.position + delta;
            // ʹ��ƽ�������ƶ������
            transform.position = Vector3.Lerp(transform.position, destination, smoothSpeed * Time.deltaTime);
        }
    }

}
