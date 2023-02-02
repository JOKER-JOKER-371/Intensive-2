using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour
{
    [SerializeField]
    GameObject Box;


    Light mylight;
    void Start()
    {
        mylight = GetComponent<Light>();
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            mylight.enabled = !mylight.enabled;
        }
    }

    private void OnTriggerEnter(Collider box){

    

    }


}
