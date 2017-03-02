using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeDate : MonoBehaviour {
    Text text;
    Text txtDate;
    public GameObject obj,objtxt;
    public ChangeDate importMonth, importDay, importYear, count;
    public string data;
    public bool hah = false;
    public int month = 0, day = 1, year = 2017, check = 0;
    string theDayOfTheWeek;
    string[] months = new string[12] { "Jan","Feb","Mar","April","May", "June", "July", "Aug", "Sept","Oct","Nov","Dec"};
    //System.DateTime dt; 
	// Use this for initialization
	void Start () {
        text = obj.GetComponent<Text>();
        //txtDate = objtxt.GetComponent<Text>();
        int theMonth = System.DateTime.Now.Month;
        importMonth.month =  theMonth - 1;
       
        importDay.day = System.DateTime.Now.Day;
        importYear.year = System.DateTime.Now.Year;
        //dt = new System.DateTime(importYear.year, importMonth.month, importDay.day);
        
    }
	
	// Update is called once per frame
	void Update () {
        //if(importMonth.month == 0)
        //    text.text = months[0] + " " + day + " " + year;
        //dt = new System.DateTime(importYear.year, importMonth.month, importDay.day);
        //txtDate.text = dt.DayOfWeek.ToString();
        if (importMonth != null)
            month = importMonth.month;
        if (importDay != null)
            day = importDay.day;
        if (importYear != null)
            year = importYear.year;
        data = months[month] + " " + day + " " + year;
        text.text = months[month] + " " + day + " " + year;
        if (day > 31)
            day = 1;

        if (month > 11)
            month = 0;
	}
    public void nxtMonth()
    {
        importMonth.month++;
        if (importMonth.month > 11)
            importMonth.month = 0;

    }
    public void nxtDay()
    {
        importDay.day++;
       
    }
    public void nxtYear()
    {
        importYear.year++;
    }
    public void backMonth()
    {
        importMonth.month--;
        if (importMonth.month < 0)
            importMonth.month = 11;
    }
    public void backDay()
    {
        importDay.day--;
        if(day<1)
            day = 31;
    }
    public void backYear()
    {
        importYear.year--;
    }
}
