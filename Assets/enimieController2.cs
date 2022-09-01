using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimieController2 : MonoBehaviour
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
            Destroy(gameObject);
            transform.position = new Vector3(0, 1000, 0);
            Player.CrushSound();
        }
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "laser")
        {
            Destroy(gameObject);
            Player.CrushSound();

        }    
    }

}
