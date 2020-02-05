using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note_Checker : MonoBehaviour
{
    public GameObject note_1;
    public GameObject note_2;

    private Choice_Controller CC;

    void Start()
    {
        CC = GameObject.Find("Event_Manager").GetComponent<Choice_Controller>();

        if (!CC.choice_data[7])
        {
            note_1.SetActive(false);
        }
        if (!CC.choice_data[11])
        {
            note_2.SetActive(false);
        }
    }

    void Update()
    {
    }
}
