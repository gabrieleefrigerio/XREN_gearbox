using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveHolo : MonoBehaviour
{
    public GameObject hologram = null;
    public GameObject sensor = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == sensor)
        { 
            hologram.GetComponent<MeshRenderer>().enabled = false;
            Debug.Log("++++++++++++++INFO++++++++++++++++++");
            Debug.Log(other.gameObject == sensor);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == sensor)
        {
            hologram.GetComponent<MeshRenderer>().enabled = true;
            Debug.Log("++++++++++++++INFO++++++++++++++++++");
            Debug.Log(other.gameObject == sensor);
        }
    }
}
