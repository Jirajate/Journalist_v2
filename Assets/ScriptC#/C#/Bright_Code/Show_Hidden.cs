using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Hidden : MonoBehaviour
{
    public int event_number;
    public GameObject hidden;
    private Event_Manager EM;

    void Start()
    {
        EM = GameObject.Find("Event_Manager").GetComponent<Event_Manager>();
    }

    void Update()
    {
        if (EM.event_data[event_number])
        {
            hidden.SetActive(true);
        }
    }
}
