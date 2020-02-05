using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choice_Controller : MonoBehaviour
{
    public bool[] choice_data;

    private Image image_1;
    private Image image_2;
    private Button button_1;
    private Button button_2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "conclusion01")
        {
            image_1 = GameObject.Find("button_enable").GetComponent<Image>();
            image_2 = GameObject.Find("button_disable").GetComponent<Image>();
            button_1 = GameObject.Find("button_enable").GetComponent<Button>();
            button_2 = GameObject.Find("button_disable").GetComponent<Button>();
            if (choice_data[0] || choice_data[1] || choice_data[2] || choice_data[3] || choice_data[4] || choice_data[5] || choice_data[6])
            {
                image_1.enabled = true;
                image_2.enabled = false;
                button_1.enabled = true;
                button_2.enabled = false;
            }
            else
            {
                image_1.enabled = false;
                image_2.enabled = true;
                button_1.enabled = false;
                button_2.enabled = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "gp2_conclusion")
        {
            image_1 = GameObject.Find("button_enable").GetComponent<Image>();
            image_2 = GameObject.Find("button_disable").GetComponent<Image>();
            button_1 = GameObject.Find("button_enable").GetComponent<Button>();
            button_2 = GameObject.Find("button_disable").GetComponent<Button>();
            if (choice_data[7] || choice_data[8] || choice_data[9] || choice_data[10] || choice_data[11])
            {
                image_1.enabled = true;
                image_2.enabled = false;
                button_1.enabled = true;
                button_2.enabled = false;
            }
            else
            {
                image_1.enabled = false;
                image_2.enabled = true;
                button_1.enabled = false;
                button_2.enabled = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "gp3_conclusion")
        {
            image_1 = GameObject.Find("button_enable").GetComponent<Image>();
            image_2 = GameObject.Find("button_disable").GetComponent<Image>();
            button_1 = GameObject.Find("button_enable").GetComponent<Button>();
            button_2 = GameObject.Find("button_disable").GetComponent<Button>();
            if (choice_data[12] || choice_data[13] || choice_data[14])
            {
                image_1.enabled = true;
                image_2.enabled = false;
                button_1.enabled = true;
                button_2.enabled = false;
            }
            else
            {
                image_1.enabled = false;
                image_2.enabled = true;
                button_1.enabled = false;
                button_2.enabled = true;
            }
        }
    }
}
