using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenuByESC : MonoBehaviour {

    public Animator transitionAnim;
    public string sceneName;
    public GameObject stop;
    public PlayerController player;

    private void Start()
    {
        transitionAnim = GameObject.Find("BlackFadeScene").GetComponent<Animator>();
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (Time.timeScale == 1) //means if not pause
            {
                Time.timeScale = 0;//then pause the game

                if(stop!=null)
                    stop.SetActive(true);

                player.canMove = false;
            }

            else
            {
                Time.timeScale = 1;//else resume the game
                if (stop != null)
                    stop.SetActive(false);
                player.canMove = true;
            }
        }

    }

    IEnumerator LoadSceneAnim()
    {
        transitionAnim.SetTrigger("endScene");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;//else resume the game
        if (stop != null)
            stop.SetActive(false);
        player.canMove = true;
    }

    public void MenuButton(string name)
    {

        if (name != null)
        {
            sceneName = name;
        }
        Debug.Log("Loading scene : " + name);
        SceneManager.LoadScene(name);
    }

}
