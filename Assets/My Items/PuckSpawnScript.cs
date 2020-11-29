using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckSpawnScript : MonoBehaviour
{
    public GameObject item;
    public Object[] models;
    public Vector3 vector;





    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            GameObject newInstance = Instantiate(item, vector, transform.rotation) as GameObject;
        }
        

    }

    private void OnTriggerExit(Collider other)
    {

    }
}
