using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
     
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    private Rigidbody2D rg;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        } 
    }

    private void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        transform.Translate(moveInput * Vector2.right * moveSpeed * Time.deltaTime);
    }

    private void Jump()
    {
        rg.AddForce(Vector2.up*jumpForce,ForceMode2D.Impulse);

    }
}
