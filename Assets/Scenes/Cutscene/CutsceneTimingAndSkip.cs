using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneTimingAndSkip : MonoBehaviour
{
    public string sceneNameCs;

    private void Start()
    {
        StartCoroutine(WaitUntilCutsceneDone());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (sceneNameCs != "")
            {
                SceneManager.LoadScene(sceneNameCs);
            }
        }
    }

    [SerializeField] private float timer;

    IEnumerator WaitUntilCutsceneDone()
    {
        yield return new WaitForSeconds(timer);

        if (sceneNameCs != "")
        {
            SceneManager.LoadScene(sceneNameCs);
        }
    }
}
