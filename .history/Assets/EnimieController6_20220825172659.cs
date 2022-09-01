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
    // Not forget to add Animation Curve
    void Update()
    {
        transform.position = startposition + new Vector3(curve.Evaluate(Time.time / 2) * 5, 0, 0);        
    }

    // Collider1: Player kills Enemy
    // Editor: "Is Trigger" is checked 
    // normally Player jumps on the Enemy to kill him.
    // but not for this kind of Enemy because he moves upper and down.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter2D");
        //if (collision.gameObject.tag == "Player")
        //{
            //Destroy(gameObject);
            //transform.position = new Vector3(0, 1000, 0);
        //}


    }

    // Collider2: Enemy kills Player
    // Editor: "Is Trigger" is NOT checked
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D");
        if (collision.gameObject.tag == "laser")
        {
            Destroy(gameObject);
            Player.CrushSound();
        }

        // FIXME: stupid michael's idea: namely the upper
        // border aka german word "Decke" is so-called
        // "trigger2"... seems to be confusing...
        if (collision.gameObject.tag == "trigger2")
        {
            Destroy(gameObject);
            Player.CrushSound();
        }
    }

}
