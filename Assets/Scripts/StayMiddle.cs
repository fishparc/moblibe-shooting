using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayMiddle : MonoBehaviour
{
   public Transform terrorist;
   public Transform president;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 middle =(terrorist.position + president.position)/2;
        transform.position=middle;
    }
}
