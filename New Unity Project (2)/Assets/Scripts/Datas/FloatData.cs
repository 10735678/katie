using UnityEngine;

[CreateAssetMenu]
public class floatData : ScriptableObject
{
    public float value = 1f;

    public void ChangeValue(float number)
    {
        value += number;
    }
}

