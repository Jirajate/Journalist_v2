using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnScript : MonoBehaviour {

    public Animator transitionAnim;
    public string sceneName;

    private string scene_name;
    private Choice_Controller CC;

    private void Start()
    {
        transitionAnim = GameObject.Find("BlackFadeScene").GetComponent<Animator>();        
    }

    public void SceneLoad(string name) {

        if (name != null)
        {
            sceneName = name;
        }
        StartCoroutine(LoadSceneAnim());
    }

    IEnumerator LoadSceneAnim()
    {
        scene_name = SceneManager.GetActiveScene().name;
        transitionAnim.SetTrigger("endScene");
        yield return new WaitForSeconds(1.5f);
        if (scene_name == "mapHome" || scene_name == "mapHomeToSalaUptree" || scene_name == "mapSalaMooBan" || scene_name == "mapPB" || scene_name == "mapTreeBig" || scene_name == "mapMazeToTreeBig" || scene_name == "mapGarage")
        {
            SceneManager.LoadScene("conclusion01");
        }
        else if(scene_name == "gp2_mapHome" || scene_name == "gp2_mapHomeToSalaUptree" || scene_name == "gp2_mapPB" || scene_name == "gp2_mapSalaMooBan" || scene_name == "gp2_mapTreeBig")
        {
            SceneManager.LoadScene("gp2_conclusion");
        }
        else if (scene_name == "gp3_mapHome" || scene_name == "gp3_mapPB" || scene_name == "gp3_mapUnderHome")
        {
            SceneManager.LoadScene("gp3_conclusion");
        }
        else if (scene_name == "gp3_conclusion")
        {
            CC = GameObject.Find("Event_Manager").GetComponent<Choice_Controller>();
            if (CC.choice_data[12])
            {
                SceneManager.LoadScene("Ending1"); 
            }
            else if (CC.choice_data[13])
            {
                SceneManager.LoadScene("Ending2");
            }
            else if(CC.choice_data[14])
            {
                SceneManager.LoadScene("Ending3");
            }
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Clear Save");
    }

}
