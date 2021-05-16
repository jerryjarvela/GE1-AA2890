using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingObject : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    Rigidbody myRigidbody;
    MeshRenderer myMeshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    private void Update()
    {
        DropObjects();
    }

    private void DropObjects()
    {
        if (Time.time >= timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
