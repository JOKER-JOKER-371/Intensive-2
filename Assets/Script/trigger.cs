using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{

    [SerializeField]
    GameObject door;

    bool isLighted = false;


    

    void OnTriggerEnter(Collider col){
        
        if (!isLighted){
            isLighted = true;
            door.transform.position += new Vector3 (0, 100, 0);
        }


        
    }







}
