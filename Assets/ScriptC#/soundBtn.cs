using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundBtn : MonoBehaviour
{

    public AudioSource btnSound;
    public AudioSource toggleSound;

    private void Start()
    {
       
    }


    public void PlaySoundButton()
    {
        if(btnSound!=null)
            btnSound.Play();
    }

    public void PlayToggleSound()
    {
        if(toggleSound!=null)
            toggleSound.Play();
    }


}
