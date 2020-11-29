using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class georgeScript : MonoBehaviour
{
    public Animator controller;
    public AudioSource sound;

    void Start()
    {
        controller = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            controller.SetTrigger("trigger");
            sound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            controller.SetTrigger("trigger");
        }
    }
}
