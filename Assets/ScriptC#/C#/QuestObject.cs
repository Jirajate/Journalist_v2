using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour {

    public int questNumber;

    public QuestManager theQm;

    public string[] startText;
    public string[] endText;

    public bool isItemQuest;
    public string targetItem;

    public GameObject nextQuest01;

    private void Start()
    {
        if (nextQuest01 != null) {
            nextQuest01.SetActive(false);
        }
    }

    private void Update()
    {
        if (isItemQuest)
        {
            if(theQm.itemCollected == targetItem)
            {
                theQm.itemCollected = null;
                EndQuest();
            }
        }
    }

    public string npcName2;

    public void StartQuest()
    {
        theQm.NpcNameQuest(npcName2);
        theQm.ShowQuestText(startText);
    }

    public void EndQuest()
    {
        theQm.ShowQuestText(endText);
        theQm.questCompleted[questNumber] = true;
        gameObject.SetActive(false);

        if (nextQuest01 != null)
        {
            nextQuest01.SetActive(true);
        }
    }
}
