using UnityEngine;
using System.Collections;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.UI;
public class Gmail : MonoBehaviour {
    public bool mailSent = false;
    public ChangeDate theDate;
    public GameObject obj;
    Text text;
    string AptDate;
    public bool animate = false;
    bool hasSent = false;
    int count = 0;
    bool timer = false;
    public string[] datas = new string[100];
    public string data;
    public int totalLines;
    public bool finished = false;
    public getData getdata;
    public string goal;
    // Use this for initialization
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
        string newText = datas[1].TrimStart('#');
        goal = newText;
        AptDate = theDate.data;
        if (timer)
        {
            count++;
            if (count < 50)
                text.text = "Wait";
            if (count > 50)
            {
                sendMail();
                timer = false;
            }
        }
    }
    void OnMouseDown()
    {
        mailSent = true;

        MailMessage mail = new MailMessage();

        mail.From = new MailAddress("wsu.appcub@gmail.com");
        //for (int i = 0; i < datas.Length; i++)
        //{
        //    mail.To.Add(datas[i]);
        //}
        mail.To.Add("wsu.appclub@gmail.com");
        mail.Subject = "App Dev Club Meet";
        mail.Body = "This is an official email from the Application Development Club. Our next meeting will be 7 - 9 PM " + AptDate;
        
        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        smtpServer.Port = 587;
        smtpServer.Credentials = new System.Net.NetworkCredential("wsu.appclub@gmail.com", "allenandniko") as ICredentialsByHost;
        smtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };
        smtpServer.Send(mail);
        Debug.Log("success");

    }
    public void ActivateMail()
    {
        if (!hasSent)
        {
            text.text = "Wait";
            timer = true;
        }
       
    }
    public void sendMail()
    {
        
        if (!hasSent)
        {
            string theText = datas[3].TrimStart('#');
            mailSent = true;

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("wsu.appclub@gmail.com");
            for (int i = 1; i < datas.Length; i++)
            {
                mail.To.Add(datas[i]);
            }
            
            mail.Subject = "App Dev Club Meet";
            mail.Body = PlayerPrefs.GetString("email") + AptDate;

            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;
            smtpServer.Host = "smtp.gmail.com";
            //smtp.Port = 587;
            smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpServer.Credentials = new System.Net.NetworkCredential("wsu.appclub@gmail.com", "allenandniko") as ICredentialsByHost;
            smtpServer.EnableSsl = true;
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                { return true; };
            smtpServer.Send(mail);



            Debug.Log("success");
            animate = true;
            
            text.text = "Sent";
            hasSent = true;
        }
    }
    string MyEscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }
    public void mailWorkAround()
    {
            string email = "wsu.appclub@gmail.com";
            string subject = MyEscapeURL("My Subject");
            string body = MyEscapeURL("Hello Niko!!");
            Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
        animate = true;
        
    }

    public void sendSignInSheet()
    {
        if (!hasSent)
        {
            string theText = datas[3].TrimStart('#');
            mailSent = true;

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("wsu.appclub@gmail.com");
            mail.To.Add("wsu.appclub@gmail.com");

            mail.Subject = "App Dev Club Meet";
            mail.Body = PlayerPrefs.GetString("SignInData");

            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;
            smtpServer.Host = "smtp.gmail.com";
            //smtp.Port = 587;
            smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpServer.Credentials = new System.Net.NetworkCredential("wsu.appclub@gmail.com", "allenandniko") as ICredentialsByHost;
            smtpServer.EnableSsl = true;
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                { return true; };
            smtpServer.Send(mail);



            Debug.Log("success");
            animate = true;

            text.text = "Sent";
            hasSent = true;
        }
    }
    public void sendInvite()
    {
        if (!hasSent)
        {
            string theText = datas[3].TrimStart('#');
            mailSent = true;

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("wsu.appclub@gmail.com");
            mail.To.Add(PlayerPrefs.GetString("sendTo"));

            mail.Subject = "Welcome to Application Development Club";
            mail.Body = PlayerPrefs.GetString("inviteMail");

            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;
            smtpServer.Host = "smtp.gmail.com";
            //smtp.Port = 587;
            smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpServer.Credentials = new System.Net.NetworkCredential("wsu.appclub@gmail.com", "allenandniko") as ICredentialsByHost;
            smtpServer.EnableSsl = true;
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                { return true; };
            smtpServer.Send(mail);



            Debug.Log("success");
            animate = true;

            text.text = "Sent";
            hasSent = true;
        }
    }
}
