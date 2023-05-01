using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCamera : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 offset;
    public float smoothSpeed = 0.5f;  // 相机跟随的平滑度

    private void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    void LateUpdate()
    {

        Vector3 desiredPosition = playerTransform.position + playerTransform.rotation*offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);  // 计算相机的平滑位置
        transform.position = smoothedPosition;  // 更新相机位置
        transform.LookAt(playerTransform);
    }
}
