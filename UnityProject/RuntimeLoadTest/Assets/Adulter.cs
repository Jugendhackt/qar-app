using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adulter : MonoBehaviour
{

    GameObject childd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        childd = GameObject.Find("Downloaded(Clone)");
        childd.transform.SetParent(transform);
    }
}
