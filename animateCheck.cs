using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateCheck : MonoBehaviour {
    public bool animate = false;
    public GameObject obj;
    public float movespeed = 40;
    public Gmail mail;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (mail.animate)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, obj.transform.position, movespeed);
        }
    }
}
