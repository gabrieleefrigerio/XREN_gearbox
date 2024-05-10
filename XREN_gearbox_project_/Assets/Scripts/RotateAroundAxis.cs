using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundAxis : MonoBehaviour
{
    public GameObject component = null;
    public int degreesPerSecond = 0;
    private Rigidbody rb = null;
    private Transform tf = null;
    private Vector3 localRotation = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        tf = component.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
