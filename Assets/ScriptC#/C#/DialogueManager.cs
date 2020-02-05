using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Put in Empty GameObject for Dialogue Box Group
public class DialogueManager : MonoBehaviour {

    private PlayerController thePlayer;
    public GameObject dBox;
    public Text dText;
    public bool dialogActive;

    [TextArea(3,10)]
    public string[] dialogueLines;
    public int currentLine;

    public Text npcName;    

    private void Start()
    {
        talkTimes = 0;
        thePlayer = FindObjectOfType<PlayerController>();        
    }

    void Update () {

        Debug.Log(talkTimes);

		if (dialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            currentLine++;      
        }

        if (currentLine >= dialogueLines.Length) //close Dialogue
        {
            dBox.SetActive(false);
            dialogActive = false;
            currentLine = 0;
            thePlayer.canMove = true;
            doneTalk = true;
            print(doneTalk);
        }

        dText.text = dialogueLines[currentLine];
    }

    public bool doneTalk;
    public int talkTimes;

    public void ShowDialogue() 
    {        
        dialogActive = true;
        dBox.SetActive(true);
        thePlayer.canMove = false;
        doneTalk = false;
        talkTimes++;
    }

    
}
