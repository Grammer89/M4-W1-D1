using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    ColorManager _colorManager;
    MeshRenderer _meshRenderer;
    SetColor[] _quadList;
    // Start is called before the first frame update
    void Awake()
    {
        _colorManager = FindObjectOfType<ColorManager>();
        _meshRenderer = GetComponent<MeshRenderer>();

    }
    private void Start()
    {
        _quadList = FindObjectsOfType<SetColor>();
    }
    private void OnMouseDown()
    {
        if (_colorManager != null)
        {
            _colorManager.ModifyColor(_meshRenderer.material.color);
            for (int i = 0; i < _quadList.Length; i++)
            {
                _quadList[i].SetColorMaterial(_meshRenderer.material.color);
            }
        }
    }
}
