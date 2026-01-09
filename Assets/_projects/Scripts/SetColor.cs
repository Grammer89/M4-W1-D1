using UnityEngine;

public class SetColor : MonoBehaviour
{
    [SerializeField] LayerMask _layerMask;
    private Color _newColor;
    MeshRenderer _render;
    Camera _cam;
    private void Awake()
    {
        _render = GetComponent<MeshRenderer>();
        _cam = Camera.main;
    }
    //M4-W1-D1
    ////private void OnMouseDown()
    ////{
    ////    //Viene Settato il colore corretto selezionato

    ////    _render.material.color = _newColor;
    ////}

    private void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            _render.material.SetColor("_BaseColor", Color.white);
        }
        //M4-W1-D4
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Debug.Log("Attivo il RayCasting");
            Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow);

            if (Physics.Raycast(ray.origin, ray.direction, out hit, 2000f, _layerMask))
            {
                Debug.Log("Il laserone ha colpito" + hit.collider.gameObject.name);
                MeshRenderer render = hit.collider.gameObject.GetComponent<MeshRenderer>();
                render.material.color = _newColor;
            }
        }
    }

    public void SetColorMaterial(Color color)
    {
        Debug.Log("Viene Settato il colore: " + _render.material.color);
        _newColor = color;
    }
}
