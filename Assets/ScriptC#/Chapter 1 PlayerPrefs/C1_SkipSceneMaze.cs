using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class C1_SkipSceneMaze : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneName;
    public string skipToScene;

    string _boolean;

    private void Start()
    {
        transitionAnim = GameObject.Find("BlackFadeScene").GetComponent<Animator>();
        _boolean = PlayerPrefs.GetString("ClearMaze");
        Debug.Log("ClearMaze is "+_boolean);
    }

    IEnumerator LoadSceneAnim()
    {
        transitionAnim.SetTrigger("endScene");
        yield return new WaitForSeconds(1.5f);

        if (_boolean == "True") // If Player already clear maze, SKIP the maze
        {
            SceneManager.LoadScene(skipToScene);
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }

    }

    [SerializeField] private string playerComefrom;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            PlayerPrefs.SetString("ComeFrom", playerComefrom);
            StartCoroutine(LoadSceneAnim());
        }
    }

    private void Update()
    {
        _boolean = PlayerPrefs.GetString("ClearMaze");

        if (Input.GetKeyDown(KeyCode.Q)) //Reset ClearMaze to False
        {
            PlayerPrefs.SetString("ClearMaze","False");
            Debug.Log("ClearMaze is " + _boolean);
        }
    }
}
