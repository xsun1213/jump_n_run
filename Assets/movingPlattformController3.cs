using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlattformController3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(12 * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position += new Vector3(3 * Time.deltaTime, 0, 0);
        }
       

    }
}
