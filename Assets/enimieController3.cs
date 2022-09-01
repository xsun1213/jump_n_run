using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimieController3 : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public PlayerController Player;

    // Start is called before the first frame update
    public AnimationCurve curve;
    Vector3 startposition;
    // Start is called before the first frame update
    void Start()
    {
        startposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startposition + new Vector3(curve.Evaluate(Time.time/2) * 5, 0 , 0);
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
    public void Move()
    {
        rb2D.velocity = new Vector3(-8, rb2D.velocity.y, 0);
    }

}

