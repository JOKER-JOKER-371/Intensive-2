using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiggerHappen : MonoBehaviour
{

    private Color oldColor = Color.white;
    private void OnTriggerEnter(Collider other){

        if (other.CompareTag("Player") ){
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.green;
            print("it works");
        }



    }

    private void OnTriggerExit(Collider other){

        Renderer render = GetComponent<Renderer>();
        render.material.color = oldColor;



    }





}
