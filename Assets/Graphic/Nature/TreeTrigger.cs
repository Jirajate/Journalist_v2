using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTrigger : MonoBehaviour
{
    public GameObject showText;

    private void Start()
    {
        showText.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player") {
            showText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        showText.SetActive(false);
    }
}
