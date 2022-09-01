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
}
