using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    void Start()
    {

    }

    void Update()
    {
        //transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        //Debug.Log(Input.GetAxis("Horizontal"));
    }
}
