using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSelf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private Color m_oldColor = Color.white;

    private void OntriggerEnter(Collider other){
        if(other.tag == "Trigger"){
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.green;
        Debug.Log("Triggered!");
        }
    }

}
