using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimieController : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public PlayerController Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hello");
        if (collision.gameObject.tag == "Player")
        {
            Player.CrushSound();
            
            Destroy(gameObject);
            transform.position = new Vector3(0, 1000, 0);
            
        }
    }
    public void Move()
    {
        rb2D.velocity = new Vector3(-8, rb2D.velocity.y, 0);
    }
    public void Move2()
    {
        rb2D.velocity = new Vector3(8, rb2D.velocity.y, 0);
    }

}
