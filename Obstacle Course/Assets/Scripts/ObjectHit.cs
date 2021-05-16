using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer myMeshRenderer;

    private void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(CollisionColorChange());
            gameObject.tag = "Hit";
        }
    }

    IEnumerator CollisionColorChange()
    {
        myMeshRenderer.material.color = Color.red;
        yield return new WaitForSeconds(1.5f);
        myMeshRenderer.material.color = Color.white;
    }
}
