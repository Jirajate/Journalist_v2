using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoadScenePosition : MonoBehaviour
{
    public GameObject player;

    public GameObject upPos;
    public GameObject downPos;
    public GameObject leftPos;
    public GameObject rightPos;

    private void Start()
    {
        player = GameObject.Find("Player");

        if (PlayerPrefs.GetString("ComeFrom") == "Down") {
            //print("Player come from Down");

            if (downPos != null) {
                player.transform.position = downPos.transform.position;
            }
        }

        if (PlayerPrefs.GetString("ComeFrom") == "Right")
        {
            //print("Player come from Right");
            if (rightPos != null)
            {
                player.transform.position = rightPos.transform.position;
            }
        }

        if (PlayerPrefs.GetString("ComeFrom") == "Left")
        {
            //print("Player come from Left");

            if (leftPos != null)
            {
                player.transform.position = leftPos.transform.position;
            }
        }

        if (PlayerPrefs.GetString("ComeFrom") == "Up")
        {
            //print("Player come from Up");

            if (upPos != null)
            {
                player.transform.position = upPos.transform.position;
            }
        }

    }

}
