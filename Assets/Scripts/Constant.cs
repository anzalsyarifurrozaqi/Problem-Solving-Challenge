using UnityEngine;

public class Constant : MonoBehaviour
{
    public float ConstantSpeed;
    public Vector3 Direction;
    private Rigidbody rb;    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Direction * ConstantSpeed);
    }

    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Direction = collision.contacts[0].point;
        rb.AddForce(Direction * ConstantSpeed);
    }
}
