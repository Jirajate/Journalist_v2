using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleTest : MonoBehaviour
{
    [SerializeField]
    int x = 0;

    int sum = 0;

    public bool isHave1 = true;
    public bool isHave2 = false;

    public Toggle x1;
    public Toggle x2;

    private void Update()
    {
        CheckIfPlayerHaveItem();
    }

    public void CheckIfPlayerHaveItem()
    {
        if (isHave1)
        {
            x1.GetComponent<Toggle>().interactable = true;
        }
        else
        {
            x1.GetComponent<Toggle>().interactable = false;
        }

        if (isHave2)
        {
            x2.GetComponent<Toggle>().interactable = true;
        }
        else
        {
            x2.GetComponent<Toggle>().interactable = false;
        }
    }

    public void ToggleValue(int a)
    {
        x = a;
    }

    public void ValueChanged(Toggle t)
    {
        if (t.isOn)
        {
            t.GetComponentInChildren<Text>().text = "Toggle is on";
            sum += x;
            print(sum);
        }
        else
        {
            t.GetComponentInChildren<Text>().text = "Toggle is off";
            if (sum != 0)
            {
                sum -= x;
                print(sum);
            }
        }
    }




    public int ansSum = 0;

    public void ConfirmAnswer()
    {
        ansSum = sum;
        print(ansSum);
    }

}
