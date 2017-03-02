using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getData : MonoBehaviour {
    Text text;
    public bool finished = false,check = false;
    public string data;
    public string[] datas = new string[100];
    public int totalLines = 0;
    public int question;
    public int textLength;
    int lastQuestion;
    public bool touchable = false;
    public bool yes = true;
    public GameObject obj;
    int count = 1;
    
    
    IEnumerator Start()
    {

        text = obj.GetComponent<Text>();
        WWW www = new WWW("http://wwwnikostudios.000webhostapp.com/contacts.txt");
        yield return www;
        if (www.isDone)
        {
            finished = true;
        }
        else
        {
            text.text = www.error;
        }
        data = www.text;
        datas = data.Split("#"[0]);
        totalLines = datas.Length;
        
        
    }

    // Update is called once per frame
    void Update () {
        text.text = datas[2];

    }

   
   

}
