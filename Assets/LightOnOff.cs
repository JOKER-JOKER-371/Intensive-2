using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{


    private bool PlayerInZone;

    public GameObject Lightorobj;

    private void Start(){
        
        PlayerInZone = false;

        // Lightorobj.GetComponent<Light>().enabled = false;




    }

    private void Update(){
        // if (PlayerInZone && Input.GetKeyDown(KeyCode.F)){

        //     Lightorobj.SetActive(!Lightorobj.activeSelf);



        // }

    }

    private void OnTriggerEnter(Collider other){

        if (other.gameObject.tag == "Player"){

            PlayerInZone = true;

            // Lightorobj.GetComponent<Light>().enabled = true;



            Lightorobj.SetActive(!Lightorobj.activeSelf);
            print("Light on");

        }
    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Player"){
            PlayerInZone = false;

            // Lightorobj.GetComponent<Light>().enabled = false;


            print("Light OFF");
        }


        // mylight.enabled = !mylight.enabled;

    }

}
