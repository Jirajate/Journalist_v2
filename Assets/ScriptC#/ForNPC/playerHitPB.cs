using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHitPB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private bool questdone = false;

    public GameObject c1;
    public GameObject c2;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "trig1") {
            c2.SetActive(true);
            c1.SetActive(false);
        }

        if (collision.gameObject.name == "char2") {
            questdone = true;
        }
    }
}
