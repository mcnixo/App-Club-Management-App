using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClearText : MonoBehaviour {
    public InputField input;
    public InputField input2;
    public bool isSignIn = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void clearAll()
    {
        if (isSignIn)
            input.text = "Hello, this is an invite from the application development club. Information regarding our club can currently be found at appdevclub.com. We meet Monday in CUE 209 and Tuesday in CUE 316 from 7-9PM both days.";
        else
            input.text = "";
        input2.text = "";
    }
}
