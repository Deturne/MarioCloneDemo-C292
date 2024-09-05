using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformOnCollision : MonoBehaviour
{

    [SerializeField] float distance;
    private Vector3 direction = Vector3.up;
    [SerializeField] float speed;
    private Collision2D collider1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        while (collision.gameObject.tag == "Player")
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
    //void OnTriggerEnter2D(Collider2D collider)
    //{
    //    if (collider.gameObject.tag == "Player")
    //    {
    //        transform.Translate(direction * speed * Time.deltaTime);
    //    }
    //}
}
