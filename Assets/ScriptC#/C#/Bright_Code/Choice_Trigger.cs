using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choice_Trigger : MonoBehaviour
{
    public Toggle[] toggles;
    private Choice_Controller CC;

    void Start()
    {
        CC = GameObject.Find("Event_Manager").GetComponent<Choice_Controller>();
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "conclusion01")
        {
            //Toggle 1
            if (toggles[0].isOn)
            {
                CC.choice_data[0] = true;
            }
            else
            {
                CC.choice_data[0] = false;
            }
            //Toggle 2
            if (toggles[1].isOn)
            {
                CC.choice_data[1] = true;
            }
            else
            {
                CC.choice_data[1] = false;
            }
            //Toggle 3
            if (toggles[2].isOn)
            {
                CC.choice_data[2] = true;
            }
            else
            {
                CC.choice_data[2] = false;
            }
            //Toggle 4
            if (toggles[3].isOn)
            {
                CC.choice_data[3] = true;
            }
            else
            {
                CC.choice_data[3] = false;
            }
            //Toggle 5
            if (toggles[4].isOn)
            {
                CC.choice_data[4] = true;
            }
            else
            {
                CC.choice_data[4] = false;
            }
            //Toggle 6
            if (toggles[5].isOn)
            {
                CC.choice_data[5] = true;
            }
            else
            {
                CC.choice_data[5] = false;
            }
            //Toggle 7
            if (toggles[6].isOn)
            {
                CC.choice_data[6] = true;
            }
            else
            {
                CC.choice_data[6] = false;
            }
        }
        else if (SceneManager.GetActiveScene().name == "gp2_conclusion")
        {
            //Toggle 1
            if (toggles[0].isOn)
            {
                CC.choice_data[7] = true;
            }
            else
            {
                CC.choice_data[7] = false;
            }
            //Toggle 2
            if (toggles[1].isOn)
            {
                CC.choice_data[8] = true;
            }
            else
            {
                CC.choice_data[8] = false;
            }
            //Toggle 3
            if (toggles[2].isOn)
            {
                CC.choice_data[9] = true;
            }
            else
            {
                CC.choice_data[9] = false;
            }
            //Toggle 4
            if (toggles[3].isOn)
            {
                CC.choice_data[10] = true;
            }
            else
            {
                CC.choice_data[10] = false;
            }
            //Toggle 5
            if (toggles[4].isOn)
            {
                CC.choice_data[11] = true;
            }
            else
            {
                CC.choice_data[11] = false;
            }
        }
        else if (SceneManager.GetActiveScene().name == "gp3_conclusion")
        {
            //Toggle 1
            if (toggles[0].isOn)
            {
                CC.choice_data[12] = true;
            }
            else
            {
                CC.choice_data[12] = false;
            }
            //Toggle 2
            if (toggles[1].isOn)
            {
                CC.choice_data[13] = true;
            }
            else
            {
                CC.choice_data[13] = false;
            }
            //Toggle 3
            if (toggles[2].isOn)
            {
                CC.choice_data[14] = true;
            }
            else
            {
                CC.choice_data[14] = false;
            }
        }
    }
}
