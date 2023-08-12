using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Damage : MonoBehaviour
{
    public AudioClip myClip;
    private AudioSource mySource;
    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }



    void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.tag == ("Player"))
        {
            myCollider.GetComponent<HealthLevel>().healthLevel -= 10;
            mySource.PlayOneShot(myClip); 
        }
    }
}
