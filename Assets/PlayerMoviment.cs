using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    private float xMovimentInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xMovimentInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = new Vector2(xMovimentInput * speed, rb.velocity.y);
    }
}
