﻿using UnityEngine;
using UnityEngine.UI;

namespace InClass
{
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
}
