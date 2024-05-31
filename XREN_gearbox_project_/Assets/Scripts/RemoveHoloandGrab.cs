using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RemoveHoloandGrab : MonoBehaviour
{
    public GameObject hologram = null;
    public GameObject sensor = null;
    private GameObject interaction = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void Update()
    {
        if (sensor.gameObject.transform.position == hologram.gameObject.transform.position)
        {
            interaction = sensor.gameObject.transform.GetChild(0).gameObject;
            interaction.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == sensor)
        { 
            hologram.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == sensor)
        {
            hologram.GetComponent<MeshRenderer>().enabled = true;
        }

    }

}
