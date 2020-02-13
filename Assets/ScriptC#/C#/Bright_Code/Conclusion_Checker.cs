using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Conclusion_Checker : MonoBehaviour
{
    public GameObject hidden_1;
    public GameObject hidden_2;
    public GameObject hidden_3;
    public GameObject hidden_4;
    public GameObject hidden_5;
    public GameObject hidden_6;
    public GameObject hidden_7;

    private Event_Manager EM;

    void Start()
    {
        EM = GameObject.Find("Event_Manager").GetComponent<Event_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "conclusion01")
        {
            if (EM.event_data[2])
            {
                hidden_1.SetActive(false);
            }
            if (EM.event_data[3])
            {
                hidden_2.SetActive(false);
                hidden_3.SetActive(false);
            }
            if (EM.event_data[4])
            {
                hidden_4.SetActive(false);
            }
            if (EM.event_data[7])
            {
                hidden_5.SetActive(false);
                hidden_6.SetActive(false);
                hidden_7.SetActive(false);
            }
        }
        else if (SceneManager.GetActiveScene().name == "gp2_conclusion")
        {
            if (EM.event_data[8])
            {
                hidden_5.SetActive(false);
            }
            if (EM.event_data[9])
            {
                hidden_2.SetActive(false);
            }
            if (EM.event_data[10])
            {
                hidden_3.SetActive(false);
            }
            if (EM.event_data[11])
            {
                hidden_4.SetActive(false);
            }
        }
        else if (SceneManager.GetActiveScene().name == "gp3_conclusion")
        {
            if (EM.event_data[12])
            {
                hidden_1.SetActive(false);
            }
            if (EM.event_data[13])
            {
                hidden_2.SetActive(false);
            }
        }
    }
}
