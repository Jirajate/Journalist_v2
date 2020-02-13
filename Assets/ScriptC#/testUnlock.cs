using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testUnlock : MonoBehaviour {
        
    public void TestUnlock(int x)
    {
        PlayerPrefs.SetInt("LevelPassed",x);
        Debug.Log("Unlock Level "+(x+1));
    }

}
