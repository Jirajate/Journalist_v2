using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_Controller : MonoBehaviour
{
    public int i_trigger = 0;
    public int event_number = 0;
    private bool triggered = false;
    private int i = 0;
    private Event_Manager EM;
    void Start()
    {
        EM = GameObject.Find("Event_Manager").GetComponent<Event_Manager>();
    }

    void Update()
    {
        if (i == i_trigger)
        {
            EM.event_data[event_number] = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && triggered)
        {
            i++;
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        triggered = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        triggered = false;
    }
}
