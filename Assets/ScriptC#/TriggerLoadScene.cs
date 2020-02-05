using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerLoadScene : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneName;

    private void Start()
    {
        transitionAnim = GameObject.Find("BlackFadeScene").GetComponent<Animator>();
    }

    IEnumerator LoadSceneAnim()
    {
        transitionAnim.SetTrigger("endScene");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }

    [SerializeField] private string playerComefrom;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player") {
            PlayerPrefs.SetString("ComeFrom", playerComefrom);
            StartCoroutine(LoadSceneAnim());
        }
    }
}
