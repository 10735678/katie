using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class listsAndLoops : ScriptableObject
{
    public List<string> stringList;
    public string singleString;

    public void AddToList(string stringObj)
    {
        
    }

    public void RemoveFromList(string stringObj)
    {
        for (int i = 0; i < stringList.Count; i++)
        {
            if (stringList[i] == stringObj)
            {
                stringList.Remove(stringObj);
            }
        }
    }

    public void sortList()
    {
        stringList.Sort();
    }
    
    public void CheckList ()
    {
        foreach (var obj in stringList)
        {
            if (obj == singleString)
            {
                Debug.Log(obj);
            }
        }
    }

    void Update()
    {
        
    }
}
