using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erecton : MonoBehaviour
{
    public Transform egirl;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float dick=Vector3.Distance(transform.position,egirl.position);
        if(dick<2)
            {transform.localScale = new Vector3(2,2,2);
            }
            else
            {transform.localScale = new Vector3(1,1,1);
    }
}
}