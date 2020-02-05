using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Put in Dialogue Box inside NPC
public class DialogueHolder : MonoBehaviour {

    private DialogueManager dManager;
    public string npcNametxt;

    [TextArea(3, 10)]
    public string[] dialogueLines;
    	
	void Start () {
        dManager = FindObjectOfType<DialogueManager>();
	}

    bool playerArea =false;

    private void Update()
    {
        if (playerArea && Input.GetKeyDown(KeyCode.Space)) {

            if (!dManager.dialogActive)
            {

                dManager.npcName.text = npcNametxt;
                dManager.dialogueLines = dialogueLines;
                dManager.currentLine = 0;
                dManager.doneTalk = false;
                dManager.ShowDialogue();
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            playerArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerArea = false;
    }
}
