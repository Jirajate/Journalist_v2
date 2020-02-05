using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour {

	[SerializeField]
	Text codeText;

    [SerializeField]
    private string codePassword;
    
	public string codeTextValue = "";

    public GameObject btnSound;

   
	// Update is called once per frame
	void Update () {
		codeText.text = codeTextValue;

		if (codeTextValue == codePassword) {
			TriggerSafeBox.isSafeOpen = true;
        }

		if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
			
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
        btnSound.GetComponent<AudioSource>().Play();

    }

}
