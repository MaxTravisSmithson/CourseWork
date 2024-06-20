using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This part all handles the player movement
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform model;
    [SerializeField] private float speed = 5;
    [SerializeField] private float turnSpeed;
    private Vector3 input;

    //Every frame the game runs these two functions
    private void Update()
    {
        GatherInput();
        Look();
    }

    //The player can only move on a fixed update because this means the player moves the same amount no matter the frame rate
    private void FixedUpdate()
    {
        Move();
    }

    //This shows which axis need updating when it gets an update from the player
    //The Y is a 0 because it never changes on the Y axis
    private void GatherInput()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    //This part points the player in the direction they are trying to move so that they can also shoot that way
    //The turn speed uses deltaTime so that it isn't affected by frame rate, similar to the fixed update
    //The quaternions are used to represent the rotations
    private void Look()
    {
        if (input == Vector3.zero) return;

        Quaternion rot = Quaternion.LookRotation(input.ToIso(), Vector3.up);
        model.rotation = Quaternion.RotateTowards(model.rotation, rot, turnSpeed * Time.deltaTime);
    }

    //This moves the player forwards a tiny bit so when there is an input. This is done every frame so creates smooth movement
    //deltaTime is used yet again
    //The input.normalized.magnitude can be edited in Unity making it easy to test different movement speeds
    private void Move()
    {
        rb.MovePosition(transform.position + input.ToIso() * input.normalized.magnitude * speed * Time.deltaTime);
    }
}
