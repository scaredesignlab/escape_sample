using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hittest : MonoBehaviour
{
    public bool isHit;
    public AudioClip sound1;
    //AudioSource audioSource;

    private void Start()
    {
        isHit = false;
        //audioSource = GetComponent<AudioSource>();
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "testTag")
        {
            Destroy(other.gameObject);
            //audioSource.PlayOneShot(sound1);
            isHit = true;
            
        }
    }
}
