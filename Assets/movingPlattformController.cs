using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlattformController : MonoBehaviour
{
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
        transform.position = startposition + new Vector3(0, curve.Evaluate(Time.time / 3) * 10, 0);
    }
    
}
