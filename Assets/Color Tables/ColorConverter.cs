using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorConverter : MonoBehaviour
{
    [SerializeField] private Color32 _color;
    [SerializeField] private int _result;

    [ContextMenu("convert")]
    public void Convert()
    {
        _result = ConvertToInt(_color);
        Debug.Log($"int color = {_result}");
    }

    public int ConvertToInt(Color32 color)
    {
        var rgba = (color.r << 24) + (color.g << 16) + (color.b << 8) + color.a;
        return rgba;
    }
}
