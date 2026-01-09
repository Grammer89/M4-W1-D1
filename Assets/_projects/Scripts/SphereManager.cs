using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    [SerializeField] int _limitSphere;
    [SerializeField] GameObject _sphere;
    Rigidbody _rb;
    private int _count;

    public void SpawnSphere(out Vector3 randomDirection, out float randomVelocity)
    {
        if (_count <= _limitSphere)
        {

            GameObject sphere = Instantiate(_sphere);

            randomDirection = new Vector3(Random.Range(0, 15), Random.Range(0, 15), Random.Range(0, 15));
            randomVelocity = Random.Range(0, 11f);

            _count++;
        }
        else
        {
            randomDirection = Vector3.zero;
            randomVelocity = 0;
        }
    }
}
