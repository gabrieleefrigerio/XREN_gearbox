using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTransform : MonoBehaviour
{
    public GameObject parent;
    public GameObject child;
    private Transform parentTransform;
    private Transform childTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        parentTransform = parent.GetComponent<Transform>();
        childTransform = child.GetComponent<Transform>();

        child.transform.position = parentTransform.position;
    }
}
