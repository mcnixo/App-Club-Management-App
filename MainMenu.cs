using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void openMenu()
    {
        System.Threading.Thread.Sleep(150);
        SceneManager.LoadScene("Main");
    }
    public void openReminder()
    {
        System.Threading.Thread.Sleep(150);
        SceneManager.LoadScene("Reminder");
    }
    public void openMail()
    {
        System.Threading.Thread.Sleep(150);
        SceneManager.LoadScene("Mail");
    }
    public void openContacts()
    {
        Application.OpenURL("https://goo.gl/xW0sjX");
    }
    public void openKeyboard()
    {
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, false,false);
        
    }
    public void openEmailContents()
    {
        SceneManager.LoadScene("EditText");
    }
    public void openSignInSheet()
    {
        SceneManager.LoadScene("SignInSheet");
    }
    public void openSignIn()
    {
        SceneManager.LoadScene("SignIn");
    }
    public void openInvite()
    {
        SceneManager.LoadScene("Invite");
    }
}
