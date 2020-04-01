
using System.ComponentModel;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class textBehaviour : MonoBehaviour
{
    private Text textObj;
    
    void Start()
    {
        textObj = GetComponent<Text>();
    }


    public void ChangeText(string message)
    {
        textObj.text = message;
    }
    
}
