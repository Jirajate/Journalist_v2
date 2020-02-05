using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event_Manager : MonoBehaviour
{
    public bool[] event_data;

    public GameObject chat_1;
    public GameObject chat_2;
    public GameObject ui_endday_tut;
    public Canvas ui_endday;
    public AudioSource song_1;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        if (SceneManager.GetActiveScene().name == "testTut")
        {
            chat_1.SetActive(true);
            chat_2.SetActive(false);
        }
    }

    void Update()
    {

        /*################################## Music Controller ##################################*/

        if (song_1.isPlaying)
        {
            if (SceneManager.GetActiveScene().name == "tut_conclusion")
            {
                song_1.Stop();
            }
            if (SceneManager.GetActiveScene().name == "conclusion01")
            {
                song_1.Stop();
            }
            if (SceneManager.GetActiveScene().name == "gp2_conclusion")
            {
                song_1.Stop();
            }
            if (SceneManager.GetActiveScene().name == "gp3_conclusion")
            {
                song_1.Stop();
            }
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "mapHome")
            {
                song_1.Play();
            }
            if (SceneManager.GetActiveScene().name == "gp2_mapHome")
            {
                song_1.Play();
            }
            if (SceneManager.GetActiveScene().name == "gp3_mapHome")
            {
                song_1.Play();
            }
        }

        /*################################## Tutorial ##################################*/

        if (SceneManager.GetActiveScene().name == "testTut")
        {
            if (event_data[0])
            {
                chat_1.SetActive(false);
                chat_2.SetActive(true);
            }
            if (event_data[1])
            {
                ui_endday_tut.SetActive(true);
            }
        }

        /*################################## Gameplay 1 ##################################*/

        if (SceneManager.GetActiveScene().name == "mapSalaMooBan")
        {
            if (event_data[2] || event_data[3])
            {
                ui_endday.enabled = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "mapGarage")
        {
            if (event_data[2] || event_data[3] || event_data[4])
            {
                ui_endday.enabled = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "mapHome")
        {
            if (event_data[2] || event_data[3] || event_data[4])
            {
                ui_endday.enabled = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "mapHomeToSalaUptree")
        {
            if (event_data[2] || event_data[3] || event_data[4])
            {
                ui_endday.enabled = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "mapTreeBig")
        {
            if (event_data[2] || event_data[3] || event_data[4])
            {
                ui_endday.enabled = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "mapMazeTreeBig")
        {
            if (event_data[2] || event_data[3] || event_data[4])
            {
                ui_endday.enabled = true;
            }
        }

        /*################################## Gameplay 2 ##################################*/

        else if (SceneManager.GetActiveScene().name == "gp2_mapHome")
        {
            if (event_data[8] || event_data[9] || event_data[10] || event_data[11])
            {
                ui_endday.enabled = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "gp2_mapHomeToSalaUptree")
        {
            if (event_data[8] || event_data[9] || event_data[10] || event_data[11])
            {
                ui_endday.enabled = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "gp2_mapPB")
        {
            if (event_data[8] || event_data[9] || event_data[10] || event_data[11])
            {
                ui_endday.enabled = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "gp2_mapSalaMooBan")
        {
            if (event_data[8] || event_data[9] || event_data[10] || event_data[11])
            {
                ui_endday.enabled = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "gp2_mapTreeBig")
        {
            if (event_data[8] || event_data[9] || event_data[10] || event_data[11])
            {
                ui_endday.enabled = true;
            }
        }

        /*################################## Gameplay 3 ##################################*/

        else if (SceneManager.GetActiveScene().name == "gp3_mapHome")
        {
            if (event_data[12] || event_data[13])
            {
                ui_endday.enabled = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "gp3_mapPB")
        {
            if (event_data[12] || event_data[13])
            {
                ui_endday.enabled = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "gp3_mapUnderHome")
        {
            if (event_data[12] || event_data[13])
            {
                ui_endday.enabled = true;
            }
        }
        else
        {
            ui_endday.enabled = false;
        }
    }
}
