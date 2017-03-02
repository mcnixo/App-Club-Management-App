using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSize : MonoBehaviour {
    public float x;
    public float y;
    public float x1, y1;
    Vector2 theScreen;
    
    public int newScore;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
        theScreen = Camera.main.ScreenToWorldPoint(new Vector2(x, y));
        x1 = theScreen.x;
        y1 = theScreen.y;
        y = Camera.current.pixelHeight;
        x = Camera.current.pixelWidth;


    }
}
