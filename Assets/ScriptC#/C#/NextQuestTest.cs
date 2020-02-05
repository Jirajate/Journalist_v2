using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextQuestTest : MonoBehaviour
{
    public QuestManager theQm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int checkQuestDone;
    void Update()
    {
        if (theQm.countDoneQuest == checkQuestDone) {
            print("Quest " + checkQuestDone + " Completed");
            print("Turn On Next Quest");
        }
        
    }
}
