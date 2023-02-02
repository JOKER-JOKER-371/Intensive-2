using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcontorl : MonoBehaviour
{

    Light mylight;
    // Start is called before the first frame update
    void Start()
    {
        mylight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            mylight.enabled = !mylight.enabled;
        }
    }
}
