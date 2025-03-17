using UnityEngine;

public class Magnus_effect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity,spin;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Kick();
            ApplyMagnusEffect();
        }
    }

    void Kick()
    {
        rb.linearVelocity = velocity; //kick by straight force
        rb.angularVelocity = spin; //make ball spin for free kick
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(velocity,spin); // calculate magnusforce for a ball
        rb.AddForce(magnusForce); //add magnusforce to a ball
    }
}
