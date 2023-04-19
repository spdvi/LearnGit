using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.A)) 
      {
        Debug.Log("Se mueve a la izqda");  
      }
      
      if (Input.GetKey(KeyCode.W)) 
      {
        Debug.Log("Se mueve hacia adelante");  
      }
      
      else if (Input.GetKey(KeyCode.S)) 
      {
        Debug.Log("Se mueve hacia atras");  
      }
    }
}
