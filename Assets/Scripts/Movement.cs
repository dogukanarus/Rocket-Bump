using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    [SerializeField] float thrustValue;
    [SerializeField] InputAction rotation;
    [SerializeField] float rotationValue;

    Rigidbody rb;

    void OnEnable()
    {
        thrust.Enable();
        rotation.Enable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        ThrustProcess();
        RotationProcess();
    }

    void ThrustProcess()
    {
        if (thrust.IsPressed())
        {
            rb.AddRelativeForce(Vector3.up * thrustValue * Time.fixedDeltaTime);
        }

    }

    void RotationProcess()
    {
        float rotationInput = rotation.ReadValue<float>();

        if (rotationInput > 0)
        {
            ApplyRotation(-rotationValue);
        }
        else if (rotationInput < 0)
        {
            ApplyRotation(rotationValue);
        }
    }

    void ApplyRotation(float rotateDirection)
    {
        transform.Rotate(Vector3.forward * rotateDirection * Time.fixedDeltaTime);

    }
}
