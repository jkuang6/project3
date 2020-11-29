using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnDDR : MonoBehaviour
{
    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("here");
            if (item.activeSelf)
            {
                Debug.Log("here 2");
                item.SetActive(false);
            }
            else
            {
                Debug.Log("here 3");
                item.SetActive(true);
            }


        }
    }

 
}
