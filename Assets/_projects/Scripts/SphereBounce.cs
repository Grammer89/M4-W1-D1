using UnityEngine;


public class SphereBounce : MonoBehaviour
{
    private Rigidbody _rb;
    private Vector3 _randomDirection;
    private float _randomVelocity;
    // Start is called before the first frame update
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        _rb.velocity = _randomDirection.normalized * _randomVelocity;
    }

    public void Setup()
    {

        SphereManager spawnSphere = new SphereManager();
        spawnSphere.SpawnSphere(out _randomDirection, out _randomVelocity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
