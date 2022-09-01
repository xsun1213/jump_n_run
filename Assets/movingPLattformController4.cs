using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPLattformController4 : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public BossController boss;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (boss.health > 0)
        {
            transform.position += new Vector3(6 * Time.deltaTime, 0, 0);

        }

    }
}