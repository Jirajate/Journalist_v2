using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOverTest : MonoBehaviour {

    private Animator anim;
    public bool isPlaying;

    private void Start()
    {
        anim = GetComponent<Animator>();
        if (isPlaying)
        {
            anim.SetBool("Play", true);
        }
    }

    void OnMouseEnter()
    {
        anim.SetBool("Play",true);
        Debug.Log("Mouse is over GameObject.");
    }

    void OnMouseExit()
    {
        anim.SetBool("Play", false);
        Debug.Log("Mouse is over GameObject.");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
