using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimieController5 : MonoBehaviour
{

    public PlayerController Player;
    public GameObject fireprefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnLaser", 0, 2);
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
    void SpawnLaser()
    {
        GameObject laser2 = Instantiate(fireprefab);
        laser2.transform.position = transform.position + new Vector3(-50 * Time.deltaTime, 0, 0);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "laser")
        {
            Destroy(gameObject);
            transform.position = new Vector3(0, 1000, 0);
            Player.CrushSound();
        }
    }
}
