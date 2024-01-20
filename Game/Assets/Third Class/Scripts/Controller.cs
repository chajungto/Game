using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 direction;

    void Start()
    {
        Debug.Log(transform.position);
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();

        //Time.deltaTime : ������ �� �̵� ���� ����

        transform.position = transform.position + direction * speed * Time.deltaTime;
        
    }
}
