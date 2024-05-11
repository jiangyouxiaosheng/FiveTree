using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target; // 跟随的玩家对象
    public float smoothSpeed = 0.125f; // 跟随的平滑程度

    private void LateUpdate()
    {
        if (target != null)
        {
            // 计算目标位置在屏幕上的坐标
            Vector3 targetPosition = Camera.main.WorldToViewportPoint(target.position);
            // 计算摄像机应该移动的向量
            Vector3 delta = target.position - Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, targetPosition.z));//表示屏幕中心点在视口坐标系中的位置，其中z轴坐标等于目标位置在世界坐标系中的z轴坐标，保证在同一平面上，即摄像机与目标在同一水平线上。要想调镜头就在0.5f上下手。
            // 计算摄像机的目标位置
            Vector3 destination = transform.position + delta;
            // 使用平滑阻尼移动摄像机
            transform.position = Vector3.Lerp(transform.position, destination, smoothSpeed * Time.deltaTime);
        }
    }

}
