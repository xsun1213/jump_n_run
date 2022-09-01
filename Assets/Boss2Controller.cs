using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss2Controller : MonoBehaviour
{
    // Start is called before the first frame update
   
     
    public GameObject Bosslaser2prefab;
    public GameObject Bosslaserprefab;
    public Rigidbody2D rb2D;
    public AudioSource AudioSource;
    public BossController BossController;
    int Stagger = 0;
    
    int Move = 1;
    void Start()
    {
        BossController.health = 300;
        InvokeRepeating("SpawnLaser", 1, 1);
        
        

    }

    // Update is called once per frame
    void Update()
    {
        rb2D.velocity = new Vector3(6, 0, 0);
        if(BossController.health == 100)
        {
            transform.position += new Vector3(0, 10f, 0);
            BossController.health = 98;
        }


    }
    void SpawnLaser()
    {
        if (BossController.health < 100)
        {
            Stagger++;
            Move = Random.Range(1, 3);
            if (Stagger < 6)
            {
                if (Move == 1)
                {
                    Debug.Log("Dupa dupa");
                    transform.position += new Vector3(0, 200f * Time.deltaTime, 0);
                }

                if (Move == 2)
                {
                    Debug.Log("Dupa dupa1");
                    transform.position += new Vector3(0, -200f * Time.deltaTime, 0);
                }
                GameObject laser2 = Instantiate(Bosslaser2prefab);
                laser2.transform.position = transform.position + new Vector3(-140 * Time.deltaTime, 0, 0);


            }
            if (Stagger == 7)
            {
                
                if (Move == 1)
                {
                    Debug.Log("Dupa dupa");
                    transform.position += new Vector3(0, 200f * Time.deltaTime, 0);
                }

                if (Move == 2)
                {
                    Debug.Log("Dupa dupa1");
                    transform.position += new Vector3(0, -200f * Time.deltaTime, 0);
                }
                GameObject laser = Instantiate(Bosslaserprefab);
                laser.transform.position = transform.position + new Vector3(-140 * Time.deltaTime, 0, 0);



            }
            if (Stagger == 9)
            {
                Stagger = 0;
            }
        }
            
               


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "laser" && BossController.health < 100)
        {
            BossController.health -= 1;
            AudioSource.Play();
            if (BossController.health == 0)
            {
                Destroy(gameObject);
            }

        }
       
    }
}
