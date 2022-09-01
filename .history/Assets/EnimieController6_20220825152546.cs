using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimieController6 : MonoBehaviour
{

    public Rigidbody2D rb2D;
    public AnimationCurve curve;
    Vector3 startposition;
    public PlayerController Player;

    // Start is called before the first frame update
    void Start()
    {
       startposition = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startposition + new Vector3(0, curve.Evaluate(Time.time / 2) * 5, 0);        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hello");
        //if (collision.gameObject.tag == "Player")
        //{
            //Destroy(gameObject);
            //transform.position = new Vector3(0, 1000, 0);
        //}


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "laser")
        {
            Destroy(gameObject);
            Player.CrushSound();
        }
        if (collision.gameObject.tag == "trigger2")
        {
            Destroy(gameObject);
            Player.CrushSound();
        }
    }

}