using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour {

    public QuestObject[] quests;
    public bool[] questCompleted;

    public DialogueManager theDm;

    public string itemCollected;

    void Start() {
        questCompleted = new bool[quests.Length];
        countDoneQuest = 0;
    }

    int currentLine;
    public int countDoneQuest;

    private void Update()
    {
        for (int i = 0; i < questCompleted.Length; i++)
        {
            if (questCompleted[i]) {
                countDoneQuest++;
            }
        }
    }

    public void ShowQuestText(string[] questText)
    {

        theDm.dialogueLines = new string[questText.Length];
        for (int i = 0; i < questText.Length; i++) {
            theDm.dialogueLines[i] = questText[i];
        }

        theDm.currentLine = 0;
        theDm.ShowDialogue();
    }

    public void NpcNameQuest(string x)
    {
        theDm.npcName.text = x;
    }
}
