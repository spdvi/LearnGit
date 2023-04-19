using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
            Debug.Log("Jump");

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Jump hacia arriba y hacia adelante");
        }
    }
}
