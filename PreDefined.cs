using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreDefined : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetString("email", "This is an official email from the Application Development Club. Our next meeting will be 7 - 9 PM ");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
