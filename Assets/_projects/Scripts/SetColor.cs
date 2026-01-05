using UnityEngine;

public class SetColor : MonoBehaviour
{
    private Color _newColor;
    MeshRenderer _render;
    private void Awake()
    {
        _render = GetComponent<MeshRenderer>();
    }
    private void OnMouseDown()
    {
        //Viene Settato il colore corretto selezionato

        _render.material.color = _newColor;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _render.material.SetColor("_BaseColor", Color.white);
        }
    }

    public void SetColorMaterial(Color color)
    {
        Debug.Log("Viene Settato il colore: " + _render.material.color);
        _newColor = color;
    }
}
