using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlattformController : MonoBehaviour
{
    public Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="PLayer")
        {
            rb2D.gravityScale = 1;
        }
    }
}
