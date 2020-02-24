
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    private Image imageObj;
    
    // Start is called before the first frame update
    private void Start()
    {
        imageObj = GetComponent<Image>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            GetComponent<Image>().material.color = Color.red;
        }
    }
}
