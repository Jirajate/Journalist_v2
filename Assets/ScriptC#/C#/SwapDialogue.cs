using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapDialogue : MonoBehaviour
{
    private DialogueManager dManager;
    public GameObject nextQuestObj;
    public GameObject oldQuestObj;

    public GameObject oldObjSwap;
    public GameObject newObjSwap;

    [SerializeField] private int numNextQuest;

    // Start is called before the first frame update
    void Start()
    {
        dManager = FindObjectOfType<DialogueManager>();

        if (nextQuestObj != null)
        {
            nextQuestObj.SetActive(false);
            newObjSwap.SetActive(false);
        }
        numNextQuest = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (nextQuestObj != null && dManager.doneTalk == true && numNextQuest <= 0)
        {
            print(dManager.doneTalk);
            nextQuestObj.SetActive(true);
            newObjSwap.SetActive(true);

            oldQuestObj.SetActive(false);
            oldObjSwap.SetActive(false);
            numNextQuest++;
        }
    }
}
