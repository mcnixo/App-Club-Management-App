using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextField : MonoBehaviour {
    public string theEmail;
    public Text text;
    public InputField field;
	// Use this for initialization
	void Start () {
        field.text = PlayerPrefs.GetString("email");
        
    }
	
	// Update is called once per frame
	void Update () {
        theEmail = text.text;
        PlayerPrefs.SetString("email", theEmail);
    }
    public void newText()
    {
        PlayerPrefs.SetString("email", theEmail);
    }

}
