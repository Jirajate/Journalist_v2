using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tut_PB : MonoBehaviour
{
    // Start is called before the first frame update
    public DialogueManager dm;
    public GameObject[] npcCharNo;
    public bool talkToGrandmum = false;

    private void Update()
    {
        print("Talk Time " +dm.talkTimes);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player") {

            print("Hit NPC");

            if (dm.talkTimes == 0)
            {
                print("Change to 1");
                npcCharNo[0].SetActive(true);
                npcCharNo[1].SetActive(false);
                npcCharNo[2].SetActive(false);
            }

            if (dm.talkTimes >= 1)
            {
                print("Change to 2");
                npcCharNo[0].SetActive(false);
                npcCharNo[1].SetActive(true);
                npcCharNo[2].SetActive(false);

                if (talkToGrandmum)
                {
                    npcCharNo[0].SetActive(false);
                    npcCharNo[1].SetActive(false);
                    npcCharNo[2].SetActive(true);
                }

            }

        }
    }
}
