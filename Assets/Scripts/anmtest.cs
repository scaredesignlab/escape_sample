using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anmtest : MonoBehaviour
{
    Animator animator;
    GameObject mainCube;
    hittest hittes;
    //public AudioClip sound2;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //animator.SetBool("hitbool", true);
        mainCube = GameObject.Find("Cube01");
        hittes = mainCube.GetComponent<hittest>();
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hittes.isHit.Equals(true))
        {
            animator.SetBool("hitbool", true);
            //audioSource.PlayOneShot(sound2);
        }
    }
}
