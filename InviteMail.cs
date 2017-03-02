using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InviteMail : MonoBehaviour {
    public InputField field;
    public InputField email;
    public Text text;
	// Use this for initialization
	void Start () {
        field.text = PlayerPrefs.GetString("inviteMail");
        email.text = PlayerPrefs.GetString("sendTo");
	}
	
	// Update is called once per frame
	void Update () {
        
        PlayerPrefs.SetString("inviteMail", field.text);
        PlayerPrefs.SetString("sendTo", email.text);
        
	}
}
