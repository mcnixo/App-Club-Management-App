using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SignInInfo : MonoBehaviour {
    public InputField name,id,email;
    public Text text;
    public string SignInSheet;
    public string original = "";
    public bool clicked = false;
    float count = 0;
	// Use this for initialization
	void Start () {
        original = PlayerPrefs.GetString("SignInData");
	}
	
	// Update is called once per frame
	void Update () {
        if (clicked)
            count += Time.deltaTime * 2;
        SignInSheet = " #" + name.text + ", " + id.text + ", " + email.text;
	}
    public void addSubmission()
    {
        text.text = "Submitted!";
        clicked = true;
        original = original + SignInSheet;
        if(name.text != "Name" && id.text != "Coug ID#")
            PlayerPrefs.SetString("SignInData", original);
        text.text = "Submitted!";
        SceneManager.LoadScene("SignIn");

    }
}
