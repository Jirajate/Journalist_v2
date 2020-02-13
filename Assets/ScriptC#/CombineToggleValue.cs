using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CombineToggleValue : MonoBehaviour
{
    string x;

    [SerializeField]
    private List<int> toggleValue = new List<int>();

    int scoreFromItem;
    int itemPick;

    public Button confirmAns;

    private void Start()
    {
        confirmAns.GetComponent<Button>().interactable = false;
        transitionAnim = GameObject.Find("BlackFadeScene").GetComponent<Animator>();
        itemPick = 0;
    }

    private void Update()
    {
        if (itemPick <= 0)
        {
            confirmAns.GetComponent<Button>().interactable = false;
        }
        else
        {
            confirmAns.GetComponent<Button>().interactable = true;
        }
    }

    public void SelectToggle(Toggle t)
    {
        x = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        print(x);
        scoreFromItem = int.Parse(x);

        if (t.isOn)
        {
            toggleValue.Add(scoreFromItem);
            itemPick++;
        }

        else if (!t.isOn)
        {
            for (int i = 1; i < itemPick + 2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (toggleValue[j] == scoreFromItem)
                    {
                        toggleValue.Remove(scoreFromItem);
                        j = 100;
                        i = 99;
                    }
                }
            }

            itemPick--;
        }
    }

    public int sumInfoValue;

    public void CombineValue()
    {

        for (int i = 0; i < toggleValue.Count; i++) {
            sumInfoValue += toggleValue[i];
        }

        if (toggleValue.Count == 0) {
            sumInfoValue = 0;
        }

        print(sumInfoValue);
        if (sceneName != "")
        {
            //print("Go to Scene");
            StartCoroutine(LoadSceneAnim());
        }
        else
        {
            //print("Dont have Scene Name");
        }

    }

    public Animator transitionAnim;
    public string sceneName;

    IEnumerator LoadSceneAnim()
    {
        transitionAnim.SetTrigger("endScene");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }


}
