using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Unlocker : MonoBehaviour
{
    public int event_number;
    public GameObject door;
    public GameObject map;
    private Event_Manager EM;

    void Start()
    {
        EM = GameObject.Find("Event_Manager").GetComponent<Event_Manager>();
    }

    void Update()
    {
        if (EM.event_data[event_number])
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                door.SetActive(false);
                map.SetActive(true);
            }
        }
    }
}
