using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-10 * Time.deltaTime,0 , 0);
        if (transform.position.x < 0)
        {
            Destroy(gameObject);
        }
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="deadly")
        {
            
        }
        else
        {
            if (collision.gameObject.tag == "laser")
            {

            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
