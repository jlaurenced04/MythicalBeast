using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody rb;

    // Add buttons to your script using the Unity Inspector
    public Button moveUpButton;
    public Button moveDownButton;
    public Button moveLeftButton;
    public Button moveRightButton;

    void Start()
    {
        // Add click listeners to the buttons
        moveUpButton.onClick.AddListener(MoveUp);
        moveDownButton.onClick.AddListener(MoveDown);
        moveLeftButton.onClick.AddListener(MoveLeft);
        moveRightButton.onClick.AddListener(MoveRight);
    }

    // Implement movement functions
    public void MoveUp()
    {
        rb.velocity = Vector3.forward * moveSpeed;
    }

    public void MoveDown()
    {
        rb.velocity = Vector3.back * moveSpeed;
    }

    public void MoveLeft()
    {
        rb.velocity = Vector3.left * moveSpeed;
    }

    public void MoveRight()
    {
        rb.velocity = Vector3.right * moveSpeed;
    }
}
