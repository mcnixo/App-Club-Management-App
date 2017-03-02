using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MailAnimation : MonoBehaviour {
    public bool startMove = false;
    public GameObject obj;
    float movespeed = 5;
    public bool isMail = false, isSignIn = false, isInvite = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (startMove)
        {
            if (movespeed > 1)
                movespeed -= 0.2f;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, obj.transform.position, movespeed);
        }
        if(gameObject.transform.position == obj.transform.position && isMail)
        {
            SceneManager.LoadScene("Mail");
        }
        if (gameObject.transform.position == obj.transform.position && isSignIn)
        {
            SceneManager.LoadScene("SignIn");
        }
        if (gameObject.transform.position == obj.transform.position && isInvite)
        {
            SceneManager.LoadScene("Invite");
        }
    }
    public void moveIt()
    {
        startMove = true;
        movespeed = 60;
    }
}
