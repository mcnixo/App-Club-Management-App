using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SignInSheet : MonoBehaviour {
    public InputField data; 
	// Use this for initialization
	void Start () {
        data.text = PlayerPrefs.GetString("SignInData");
	}
	
	// Update is called once per frame
	void Update () {
        PlayerPrefs.SetString("SignInData", data.text);
    }
}
