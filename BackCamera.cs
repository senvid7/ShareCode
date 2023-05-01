using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCamera : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 offset;
    public float smoothSpeed = 0.5f;  // ��������ƽ����

    private void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    void LateUpdate()
    {

        Vector3 desiredPosition = playerTransform.position + playerTransform.rotation*offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);  // ���������ƽ��λ��
        transform.position = smoothedPosition;  // �������λ��
        transform.LookAt(playerTransform);
    }
}
