using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]

public class FPSInput : MonoBehaviour
{
    public float speed = 9.0f;
    public float jumpForce = 40f;
    public float gravity = -9.8f;
    private CharacterController _charController;

    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float downForce = gravity;
        if (Input.GetKeyDown("space"))
        {
            downForce += jumpForce;
        }
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;

        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = downForce;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);

        _charController.Move(movement);
    }
}
