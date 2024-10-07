using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalyerController : MonoBehaviour
{
    public float Speed = 5.0f;

    public Transform camara;

    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        Vector3 forward = camara.forward;
        Vector3 right = camara.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 Direction = (forward * moveZ + right * moveX);
        rigidbody.AddForce(Direction * Speed, ForceMode.Acceleration);

    }
}
