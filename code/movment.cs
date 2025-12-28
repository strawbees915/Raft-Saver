using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;
    public float rotationAngle = 60f;

    void Update()
    {
        // Move forward/backward relative to boat direction
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.right * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.right * speed * Time.deltaTime;

        // Rotate left/right
        if (Input.GetKeyDown(KeyCode.A))
            transform.Rotate(0f, -rotationAngle, 0f);

        if (Input.GetKeyDown(KeyCode.D))
            transform.Rotate(0f, rotationAngle, 0f);
    }
}
