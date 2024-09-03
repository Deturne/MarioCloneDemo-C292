using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    private Rigidbody2D platform;
    private int timer;
    // Start is called before the first frame update
    void Start()
    {
        platform = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        timer += 1;
    }

    private void Move()
    {
        while (timer < 5)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
     
        }
        while(timer > 5)
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }
        
    }
}
