using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatMap_Chapter1 : MonoBehaviour
{
    
    /* กด U ไปด่านบ้าน
     * กด I ไปทางเชื่อมบ้าน-ไป-ศาลา
     * กด O ไปด่านต้นไม้ใหญ่
     * กด P ไปด่านศาลาหมู่บ้าน
     * กด J ไปด่านที่ทิ้งขยะ
     * กด K ไปด่านบ้านผู้ใหญ่บ้าน
    */ 


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene("mapHome");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene("mapHomeToSalaUptree");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("mapTreeBig");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("mapSalaMooBan");
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            SceneManager.LoadScene("mapGarage");
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene("mapPB");
        }



    }
}
