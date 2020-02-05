using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour
{

    private QuestManager theQm;

    public int questNumber;

    public bool startQuest;
    public bool endQuest;

    void Start()
    {
        theQm = FindObjectOfType<QuestManager>();
    }

    bool playerInArea = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerInArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerInArea = false;
        }
    }

    public bool pressToTalk = true;

    private void Update()
    {
        if (pressToTalk)
        {
            if (playerInArea && Input.GetKeyDown(KeyCode.Space))
            {
                StartQuestF();
            }
        }
        else if (playerInArea && !pressToTalk)
        {
            StartQuestF();
        }
    }


    void StartQuestF()
    {
        Debug.Log("Start Quest : " + questNumber.ToString());

        if (!theQm.questCompleted[questNumber])
        {
            if (startQuest && !theQm.quests[questNumber].gameObject.activeSelf)
            {
                theQm.quests[questNumber].gameObject.SetActive(true);
                theQm.quests[questNumber].StartQuest();
            }

            if (endQuest && theQm.quests[questNumber].gameObject.activeSelf)
            {
                theQm.quests[questNumber].EndQuest();
            }
        }
    }
}
