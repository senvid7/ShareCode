using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    public float sensitivity = 100f;
    public float speed = 10f;
    public float zoomSpeed = 5f;
    private float horizontal;
    private float vertical;
    public float distance = 2;
    private bool isRotating = false;
    private Vector3 StartRotation ;

    private void Start()
    {
        StartRotation = transform.eulerAngles;
        Debug.Log(StartRotation);
    }
    void Update()
    {
        //float scroll = Input.GetAxis("Mouse ScrollWheel");
        //distance -= scroll * zoomSpeed;
        //transform.position = transform.rotation * new Vector3(0, 0, -distance);
        // ���ǰ��
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // �������
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        // ��������ƶ�
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        // ��������ƶ�
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        // ���������ת
        if (Input.GetKey(KeyCode.Q))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        // ���������ת
        if (Input.GetKey(KeyCode.E))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        // �������ת
        if (Input.GetMouseButtonDown(1))
        {
            isRotating = true;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            isRotating = false;
        }

        if (isRotating)
        {
            horizontal += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            vertical -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
            transform.eulerAngles = StartRotation + new Vector3(vertical, horizontal, 0);
        }
    }
}
