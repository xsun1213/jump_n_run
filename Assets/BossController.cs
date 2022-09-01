using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossController : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 300;
    
    int MoveSide = 0;
    int MoveRange = 0;
    int Attack = 0;
    public GameObject Bosslaserprefab;
    public GameObject BossEnimieprefab;
    public GameObject Bosslaser2prefab;
    public Rigidbody2D rb2D;
    public AudioSource AudioSource;
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        
        InvokeRepeating("SpawnLaser",1, 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.velocity = new Vector3(6, 0, 0);




    }
    void SpawnLaser()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (health > 100 && scene.name == "lvl 20")
        {
            MoveRange = Random.Range(0, 30);
            MoveSide = Random.Range(1, 3);
            if (scene.name == "lvl 16")
            {
                if (health < 200)
                {
                    Attack = Random.Range(1, 4);
                }
                else
                {
                    Attack = Random.Range(1, 3);
                }
            }
            else
            {
                Attack = Random.Range(1, 4);
            }

            if (MoveSide == 1)
            {
                while (MoveRange > 0)
                {
                    transform.position += new Vector3(0, -5 * Time.deltaTime, 0);
                    MoveRange -= 1;
                }
            }
            else
            {
                while (MoveRange > 0)
                {
                    transform.position += new Vector3(0, 5 * Time.deltaTime, 0);
                    MoveRange -= 1;
                }

            }
            Debug.Log("Hello1111");

            if (Attack < 3)
            {

                if (Attack == 1)
                {

                    GameObject laser = Instantiate(Bosslaserprefab);
                    laser.transform.position = transform.position + new Vector3(-140 * Time.deltaTime, 0, 0);

                }
                else
                {
                    GameObject enimie = Instantiate(BossEnimieprefab);
                    enimie.transform.position = transform.position + new Vector3(-140f * Time.deltaTime, 0, 0);

                }


            }
            else
            {
                GameObject laser2 = Instantiate(Bosslaser2prefab);
                laser2.transform.position = transform.position + new Vector3(-140 * Time.deltaTime, 0, 0);


            }
        }
    }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "laser" && health > 100)
            {
                health -= 1;
                AudioSource.Play();
                if (health == 0)
                {
                    Destroy(gameObject);
                }

            }
            if (collision.gameObject.tag == "trigger")
            {
                MoveSide = 2;


            }
            if (collision.gameObject.tag == "trigger2")
            {
                MoveSide = 1;


            }
        }
    
}
