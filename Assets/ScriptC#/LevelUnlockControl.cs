using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlockControl : MonoBehaviour {

    public Button lv2btn;
    public Button lv3btn;

    public GameObject unlock1, unlock2;

    int levelPassed;

	// Use this for initialization
	void Start () {

        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        lv2btn.interactable = false;
        lv3btn.interactable = false;

        switch (levelPassed) //unlock Level
        {            
            case 1:
                lv2btn.interactable = true;
                unlock1.SetActive(false);
                break;
            case 2:
                lv2btn.interactable = true;
                lv3btn.interactable = true;
                unlock1.SetActive(false);
                unlock2.SetActive(false);
                break;
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
