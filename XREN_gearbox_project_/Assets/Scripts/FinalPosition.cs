using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPosition : MonoBehaviour
{
    public GameObject hologram = null;
    public GameObject component = null;
    private Joint joint = null;

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
        if (other.gameObject == component)
        {
            joint = other.gameObject.AddComponent<FixedJoint>();
            joint.connectedBody = hologram.GetComponent<Rigidbody>();
        }

    }

}
