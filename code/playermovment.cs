using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float z = Input.GetAxisRaw("Horizontal"); // A / D
        float x= Input.GetAxisRaw("Vertical");   // W / S

        Vector3 move = transform.forward * x + transform.right * z;
        move.Normalize();

        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
    }
}
