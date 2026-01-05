using Unity.VisualScripting;
using UnityEngine;

public class Instantiator2D : MonoBehaviour
{
    [SerializeField] GameObject _quad;
    [SerializeField] int _row;
    [SerializeField] int _column;
    [SerializeField] float _xOffset;
    [SerializeField] float _yOffset;

    private void Awake()
    {
        for (int i = 0; i < _row; i++)
        {
            for (int j = 0; j < _column; j++)
            {
                GameObject quad = Instantiate(_quad);
                Vector3 vectorQuad = new Vector3(gameObject.transform.position.x + (i * _xOffset),
                                                 gameObject.transform.position.y + (j * _yOffset),
                                                 0);
                quad.transform.position = vectorQuad;
            }
        }
    }

}
