using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class vector3Data : ScriptableObject
{
    public Vector3 value;

    public void ChangePosition(Transform transformObj)
    {
        transformObj.position = value;
    }

    public void ChangevalueFromTransform(Transform transformObj)
    {
        value = transformObj.position;
    }

    public void ChangeVector3Data(vector3Data vector3DataObj)
    {
        vector3DataObj.value = value;
    }
    
    
}
