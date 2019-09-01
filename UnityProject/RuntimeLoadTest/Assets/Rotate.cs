using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{   



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        transform.RotateAroundLocal(Vector3.up, 0.01f);
    }
}
