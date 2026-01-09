using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBuilder : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] int _size;
    [SerializeField] float _offset;

    private void Awake()
    {
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {
                for (int k = 0; k < _size; k++)
                {
                    if ((k == 0) || //Faccia avanti
                         (i == 0 & (j >= 0 & j <= _size)) || //Lato Sx
                         (i == _size - 1 & (j >= 0 & j <= _size)) || //Lato Dx
                         (j == 0 & (i >= 0 & i <= _size)) || //Base
                         (j == _size - 1 & (i >= 0 & i <= _size)) || //"Tetto"
                         (k == _size - 1) //Ultima faccia
                        )
                    {
                        GameObject cube = Instantiate(_cube);
                        Vector3 vectorQuad = new Vector3(gameObject.transform.position.x + (i * _offset),
                                                         gameObject.transform.position.y + (j * _offset),
                                                         gameObject.transform.position.z + (k * _offset));
                        cube.transform.position = vectorQuad;
                    }
                }
            }
        }
    }

}
