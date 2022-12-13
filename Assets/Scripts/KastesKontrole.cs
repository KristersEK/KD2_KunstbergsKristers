using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KastesKontrole : MonoBehaviour
{
    //float horMove;
    //float verMove;
    public float speed = 25.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {/*
        horMove = Input.GetAxis("Horizontal");
        verMove = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horMove, 0.0f, verMove);
        */
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //print("down arrow key is held down");
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.back * speed * Time.deltaTime);
        }

    }
}
