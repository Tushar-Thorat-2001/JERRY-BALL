using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
   [SerializeField]
    Vector3 v3Force;
     [SerializeField]
     KeyCode keyPositive;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey (keyPositive))
           GetComponent<Rigidbody>().velocity = v3Force; 
    }
}