using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider7: MonoBehaviour
{
    public bool changeVar = false;
    public Material mat1;
    public Material mat2;


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
        if (changeVar)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = mat2;
            changeVar = false;
        } else
        {
            this.gameObject.GetComponent<MeshRenderer>().material = mat1;
            changeVar = true;
        }
    }
}
