
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    bool Shoot = false;
    bool rightPressed = false;
    bool leftPressed = false;
    bool UpPressed = false;
    bool DownPressed = false;
    public static int coinslvl1;
    public static int coinslvl2;
    public static int coinslvl3;
    public static int coinslvl4;
    public static int coinslvl5;
    public static int coinslvl6;
    public static int coinslvl7;
    public static int coinslvl8;
    public static int coinslvl9;
    public static int coinslvl10;
    public static int coinslvl11;
    public static int coinslvl12;
    public static int coinslvl13;
    public static int coinslvl14;
    public static int coinslvl15;
    public static int coinslvl16;
    public static int coinslvl17;
    public static int coinslvl18;
    public static int coinslvl19;
    public static int coinslvl20;
    public Rigidbody2D rb2D;
    public enimieController enimieController;
    private bool Grounded = true;
    public AudioSource AudioSource;
    public AudioSource AudioSource1;
    public int CoinCollected = 0;
    int Gamemode = 1;
    public GameObject laserprefab;
    void Start()
    {
        Application.targetFrameRate = 60;
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fly")
        {
            rb2D.gravityScale = 0.0f;
            Gamemode = 2;
        }
        if (collision.gameObject.tag == "JumpMode")
        {
            rb2D.gravityScale = 2.80f;
            Gamemode = 1;
        }
        if (collision.gameObject.tag == "JumpMode2")
        {
            rb2D.gravityScale = 2.80f;
            Gamemode = 3;
        }


        if (collision.gameObject.tag == "coin")
        {

        }
        else
        {
            if (collision.gameObject.tag == "Jump")
            {

            }

            else
            {

                if (collision.gameObject.tag == "deadly")
                {

                }

                else
                {
                    Grounded = true;
                }
            }
        }

    }
    private void OnTriggerStay2D(Collider2D collision)

    {

        if (collision.gameObject.tag == "coin")
        {

        }
        else
        {
            if (collision.gameObject.tag == "Jump")
            {

            }

            else
            {

                if (collision.gameObject.tag == "deadly")
                {

                }

                else
                {
                    Grounded = true;
                }
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Grounded = false;
    }
    public void menu()
    {
        SceneManager.LoadScene(1);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deadly")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }




        if (collision.gameObject.tag == "trigger")
        {
            enimieController.Move();
        }
        if (collision.gameObject.tag == "Finish")
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "lvl 1")
            {
                if (CoinCollected > coinslvl1)
                {
                    coinslvl1 = CoinCollected;
                }
            }
            if (scene.name == "lvl 2")
            {
                if (CoinCollected > coinslvl2)
                {
                    coinslvl2 = CoinCollected;
                }
            }
            if (scene.name == "lvl 3")
            {
                if (CoinCollected > coinslvl3)
                {
                    coinslvl3 = CoinCollected;
                }
                
            }
            if (scene.name == "lvl 4")
            {
                if (CoinCollected > coinslvl4)
                {
                    coinslvl4 = CoinCollected;
                }
            }
            if (scene.name == "lvl 5")
            {
                if (CoinCollected > coinslvl5)
                {
                    coinslvl5 = CoinCollected;
                }
            }
            if (scene.name == "lvl 6")
            {
                if (CoinCollected > coinslvl6)
                {
                    coinslvl6 = CoinCollected;
                }
            }
            if (scene.name == "lvl 7")
            {
                if (CoinCollected > coinslvl7)
                {
                    coinslvl7 = CoinCollected;
                }
            }
            if (scene.name == "lvl 8")
            {
                if (CoinCollected > coinslvl8)
                {
                    coinslvl8 = CoinCollected;
                }
            }
            if (scene.name == "lvl 9")
            {
                if (CoinCollected > coinslvl9)
                {
                    coinslvl9 = CoinCollected;
                }
            }
            if (scene.name == "lvl 10")
            {
                if (CoinCollected > coinslvl10)
                {
                    coinslvl10 = CoinCollected;
                }
            }
            if (scene.name == "lvl 11")
            {
                if (CoinCollected > coinslvl11)
                {
                    coinslvl11 = CoinCollected;
                }
            }
            if (scene.name == "lvl 12")
            {
                if (CoinCollected > coinslvl12)
                {
                    coinslvl12 = CoinCollected;
                }
            }
            if (scene.name == "lvl 13")
            {
                if (CoinCollected > coinslvl13)
                {
                    coinslvl13 = CoinCollected;
                }
            }
            if (scene.name == "lvl 14")
            {
                if (CoinCollected > coinslvl14)
                {
                    coinslvl14 = CoinCollected;
                }
            }
            if (scene.name == "lvl 15")
            {
                if (CoinCollected > coinslvl15)
                {
                    coinslvl15 = CoinCollected;
                }
            }
            if (scene.name == "lvl 16")
            {
                if (CoinCollected > coinslvl16)
                {
                    coinslvl16 = CoinCollected;
                }
            }
            if (scene.name == "lvl 17")
            {
                if (CoinCollected > coinslvl17)
                {
                    coinslvl17 = CoinCollected;
                }
            }
            if (scene.name == "lvl 18")
            {
                if (CoinCollected > coinslvl18)
                {
                    coinslvl18 = CoinCollected;
                }
            }
            if (scene.name == "lvl 19")
            {
                if (CoinCollected > coinslvl19)
                {
                    coinslvl19 = CoinCollected;
                }
            }
            if (scene.name == "lvl 20")
            {
                if (CoinCollected > coinslvl20)
                {
                    coinslvl20 = CoinCollected;
                }
            }
            SceneManager.LoadScene(1);
        }
        
    
   
        
        
        if (collision.gameObject.tag == "Jump")
        {
            rb2D.AddForce(new Vector2(0, 800));
        }
        if (collision.gameObject.tag == "trigger2")
        {
            enimieController.Move2();
        }


    }
    void Update()
    {
        if(Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.U) && Shoot == false)
        {
            Shoot = true;
            InvokeRepeating("Attack", 0, 0.1f);
        }
       
        if (Gamemode == 2)

        {
            rb2D.AddForce(new Vector2(0, 0));
            rb2D.velocity = new Vector3(6, rb2D.velocity.y, 0);
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(0, 5 * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position += new Vector3(0, -5 * Time.deltaTime, 0);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
            }


        }
    else
    {
            rb2D.velocity = new Vector3(0, rb2D.velocity.y, 0);
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (Gamemode == 1)
                {
                    rb2D.velocity = new Vector3(6, rb2D.velocity.y, 0);
                }
               else
                {
                    rb2D.velocity = new Vector3(12, rb2D.velocity.y, 0);
                }
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                
                if (Gamemode == 1)
                {
                    rb2D.velocity = new Vector3(-6, rb2D.velocity.y, 0);
                }
                else
                {
                    rb2D.velocity = new Vector3(-12, rb2D.velocity.y, 0);
                }
            }
            if(Gamemode == 1)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow) && Grounded)
                {

                    rb2D.AddForce(new Vector2(0, 500));
                }
                
                
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.UpArrow) && Grounded)
                {

                    rb2D.AddForce(new Vector2(0, 700));
                }
            }
            if (transform.position.y < -12.5f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    

    }
    public void CoinSound()
    {
        AudioSource.Play();
    }
    public void CrushSound()
    {
        AudioSource1.Play();
    }
    public void Attack()
    {
        if(Gamemode == 2)
        {
            GameObject laser = Instantiate(laserprefab);
            laser.transform.position = transform.position + new Vector3(1.5f, 0, 0);
        }
        
    }
    //public void Coin()
    //{
    //CoinCollected +=1;
    //}
}    

