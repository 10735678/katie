
using System.ComponentModel;
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
