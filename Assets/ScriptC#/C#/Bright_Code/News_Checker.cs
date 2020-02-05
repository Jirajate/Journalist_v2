using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class News_Checker : MonoBehaviour
{
    public Text[] topic;
    private Choice_Controller CC;
    void Start()
    {
        CC = GameObject.Find("Event_Manager").GetComponent<Choice_Controller>();
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "final_conclusion01")
        {
            //Topic 1
            if (CC.choice_data[0])
            {
                topic[0].enabled = true;
            }
            else
            {
                topic[0].enabled = false;
            }
            //Topic 2
            if (CC.choice_data[1])
            {
                topic[1].enabled = true;
            }
            else
            {
                topic[1].enabled = false;
            }
            //Topic 3
            if (CC.choice_data[6])
            {
                topic[2].enabled = true;
            }
            else
            {
                topic[2].enabled = false;
            }
            //Topic 4
            if (CC.choice_data[2])
            {
                topic[3].enabled = true;
            }
            else
            {
                topic[3].enabled = false;
            }
            //Topic 5
            if (CC.choice_data[4] && CC.choice_data[5])
            {
                topic[4].enabled = true;
            }
            else
            {
                topic[4].enabled = false;
            }
            //Topic 6
            if (CC.choice_data[0] && CC.choice_data[1] && CC.choice_data[2] && CC.choice_data[3] && CC.choice_data[4] && CC.choice_data[5] && CC.choice_data[6])
            {
                topic[5].enabled = true;
            }
            else
            {
                topic[5].enabled = false;
            }
        }
        else if (SceneManager.GetActiveScene().name == "gp2_final_conclusion")
        {
            //Topic 1
            if (CC.choice_data[7])
            {
                topic[0].enabled = true;
            }
            else
            {
                topic[0].enabled = false;
            }
            //Topic 2
            if (CC.choice_data[8])
            {
                topic[1].enabled = true;
            }
            else
            {
                topic[1].enabled = false;
            }
            //Topic 3
            if (CC.choice_data[9])
            {
                topic[2].enabled = true;
            }
            else
            {
                topic[2].enabled = false;
            }
            //Topic 4
            if (CC.choice_data[10])
            {
                topic[3].enabled = true;
            }
            else
            {
                topic[3].enabled = false;
            }
            //Topic 5
            if (CC.choice_data[11])
            {
                topic[4].enabled = true;
            }
            else
            {
                topic[4].enabled = false;
            }
        }
    }
}
