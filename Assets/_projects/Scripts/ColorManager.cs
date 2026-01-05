using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    MeshRenderer _render;

    private void Awake()
    {
        _render = GetComponent<MeshRenderer>();
    }

    public void ModifyColor(Color color)
    {
        _render.material.SetColor("_BaseColor", color);
    }
}
