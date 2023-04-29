using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;

public class Survey : MonoBehaviour
{
    [SerializeField] TMP_InputField participant;
    public string entry1;
    [SerializeField] Toggle gamer;
    public string entry2;
    [SerializeField] Slider gamingHrs;
    public string entry3;
    [SerializeField] Toggle vrDevice;
    public string entry4;
    [SerializeField] Slider vrHrs;
    public string entry5;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSfh_uBEBv45JID6mWiIn7jsWSnIAYN_KJHgEblAl5Ne5k3EPA/formResponse";
    
    public void Send()
    {
        StartCoroutine(Post(participant.text, gamer.isOn.ToString(), gamingHrs.value.ToString(), vrDevice.isOn.ToString(), vrHrs.value.ToString()));
    }

    IEnumerator Post(string s1, string s2, string s3, string s4, string s5)
    {
        WWWForm form = new WWWForm();
        form.AddField(entry1, s1);
        form.AddField(entry2, s2);
        form.AddField(entry3, s3);
        form.AddField(entry4, s4);
        form.AddField(entry5, s5);

        using (UnityWebRequest www = UnityWebRequest.Post(URL, form))
        {
            yield return www.SendWebRequest();
        }

    }

}