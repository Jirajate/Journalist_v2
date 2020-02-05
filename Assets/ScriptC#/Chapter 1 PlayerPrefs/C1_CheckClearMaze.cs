using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1_CheckClearMaze : MonoBehaviour
{
    [SerializeField]
    private string playerPrefsName;

    [SerializeField]
    private string setBoolPlayerPref;


    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            PlayerPrefs.SetString(playerPrefsName, setBoolPlayerPref);

            Debug.Log("Set Playerprefs - "+ playerPrefsName + " is "+ setBoolPlayerPref);
        }
    }
}
