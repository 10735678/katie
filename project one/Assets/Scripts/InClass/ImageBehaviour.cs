
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    private Image imageObj;
    public floatData dataObj;
    

    private void Start()
    {
        imageObj = GetComponent<Image>();
    }
    

    void Update()

        {
            imageObj.fillAmount = dataObj.value;
        }
    
}
