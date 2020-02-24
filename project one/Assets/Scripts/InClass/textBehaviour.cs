
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
public class textBehaviour : MonoBehaviour
{
    private Text textObj;
    public IntData dataObj;
    
    
    private void Start()
    {
        textObj = GetComponent<Text>();
    }
    

    void Update()

    {
        textObj.text = dataObj.value.ToString();
    }
    
}
