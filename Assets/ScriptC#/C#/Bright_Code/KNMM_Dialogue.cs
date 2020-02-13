using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KNMM_Dialogue : MonoBehaviour
{
    [TextArea(3, 10)]
    public string[] sentences;
    [Header("just use for check current dialogue")]
    public int i = 0;
    [Header("just use for check hitbox")]
    public bool triggered = false;

    private Text text_area;
    private Image background;
    private Text text_continue;
    private PlayerController player;
    private AudioSource click_sound;
    void Start()
    {
        text_area = GameObject.Find("KNMM_txtarea").GetComponent<Text>();
        background = GameObject.Find("KNMM_background").GetComponent<Image>();
        text_continue = GameObject.Find("KNMM_continue").GetComponent<Text>();
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        click_sound = GameObject.Find("TapSpaceBarSound").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && triggered)
        {
            Next_Dialogue();
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        triggered = true;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        triggered = false;
    }

    public void Next_Dialogue()
    {
        if (i < sentences.Length)
        {
            Show_Dialogue();
            click_sound.Play();
            text_area.text = sentences[i];
            i++;
            player.canMove = false;
        }
        else
        {
            Close_Dialogue();
            click_sound.Play();
            i = 0;
            player.canMove = true;
        }
    }

    public void Show_Dialogue()
    {
        text_area.enabled = true;
        background.enabled = true;
        text_continue.enabled = true;
    }

    public void Close_Dialogue()
    {
        text_area.enabled = false;
        background.enabled = false;
        text_continue.enabled = false;
    }

}
