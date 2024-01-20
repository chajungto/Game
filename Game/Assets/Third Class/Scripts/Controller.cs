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

        //Time.deltaTime : 프레임 간 이동 사이 간격

        transform.position = transform.position + direction * speed * Time.deltaTime;
        
    }
}
