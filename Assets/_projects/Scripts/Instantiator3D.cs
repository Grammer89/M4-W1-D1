using Unity.VisualScripting;
using UnityEngine;

public class Instantiator3D : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] int _row;
    [SerializeField] int _column;
    [SerializeField] int _depth;
    [SerializeField] float _xOffset;
    [SerializeField] float _yOffset;

    private void Awake()
    {
        for (int i = 0; i < _row; i++)
        {
            for (int j = 0; j < _column; j++)
            {
                for (int k = 0; k < _depth; k++)
                {
                    GameObject cube = Instantiate(_cube);
                    Vector3 vectorQuad = new Vector3(gameObject.transform.position.x + (i * _xOffset),
                                                     gameObject.transform.position.y + (j * _yOffset),
                                                     gameObject.transform.position.z + (k * _yOffset));
                    cube.transform.position = vectorQuad;
                }
            }
        }
    }

}
