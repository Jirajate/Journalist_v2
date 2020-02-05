using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//PUT IN  TRIGGER SAFEBOX
public class TriggerSafeBox : MonoBehaviour {

    public static bool isSafeOpen = false;
    public GameObject unlockDoorMap;
    public GameObject soundOpendoor;

    bool playOnlyOneTime;

    private void Start()
    {
        TriggerSafeBox.isSafeOpen = false;
        playOnlyOneTime = true;
        unlockDoorMap.SetActive(true);
    }

    private void Update()
    {

        if (inArea)
        {
            CodePanelUI.SetActive(true);          

        }

        if (isSafeOpen)
        {
            if (playOnlyOneTime)
            {
                soundOpendoor.GetComponent<AudioSource>().Play();
                playOnlyOneTime = false;
            }

            unlockDoorMap.SetActive(false);
            CodePanelUI.SetActive(false);
        }
    }

    public GameObject CodePanelUI;
    private bool inArea;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" &&!isSafeOpen) {
            inArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        inArea = false;
        CodePanelUI.SetActive(false);
        CodePanelUI.GetComponent<CodePanel>().codeTextValue = "";
    }
}
