using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlController : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.coinslvl1 == 42)
        {
            Debug.Log("dupa dupa Penis lacudouzhi");
        }
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
       
    }
    public void levels()
    {
        SceneManager.LoadScene(1);
      
    }
    public void lvl1()
    {
        SceneManager.LoadScene(2);
    }
    public void lvl2()
    {
        SceneManager.LoadScene(3);
    }
    public void lvl3()
    {
        SceneManager.LoadScene(4);
    }
    public void lvl4()
    {
        SceneManager.LoadScene(5);
    }
    public void lvl5()
    {
        SceneManager.LoadScene(6);
    }
    public void lvl6()
    {
        SceneManager.LoadScene(7);
    }
    public void lvl7()
    {
        SceneManager.LoadScene(8);
    }
    public void lvl8()
    {
        SceneManager.LoadScene(9);
    }
    public void lvl9()
    {
        SceneManager.LoadScene(10);
    }
    public void lvl10()
    {
        SceneManager.LoadScene(11);
    }
    public void lvl11()
    {
        SceneManager.LoadScene(12);
    }
    public void lvl12()
    {
        SceneManager.LoadScene(13);
    }
    public void lvl13()
    {
        SceneManager.LoadScene(14);
    }
    public void lvl14()
    {
        SceneManager.LoadScene(15);
    }
    public void lvl15()
    {
        SceneManager.LoadScene(16);
    }
    public void lvl16()
    {
        SceneManager.LoadScene(18);
    }
    public void lvl17()
    {
        SceneManager.LoadScene(19);
    }
    public void lvl18()
    {
        SceneManager.LoadScene(20);
    }
    public void lvl19()
    {
        SceneManager.LoadScene(21);
    }
    public void lvl20()
    {
        SceneManager.LoadScene(22);
    }
    public void DeleteSave()
    {
        SceneManager.LoadScene(17);
    }
    public void Sure()
    {
        PlayerPrefs.DeleteAll();
        PlayerController.coinslvl1 = 0;
        PlayerController.coinslvl2 = 0;
        PlayerController.coinslvl3 = 0;
        PlayerController.coinslvl4 = 0;
        PlayerController.coinslvl5 = 0;
        PlayerController.coinslvl6 = 0;
        PlayerController.coinslvl7 = 0;
        PlayerController.coinslvl8 = 0;
        PlayerController.coinslvl9 = 0;
        PlayerController.coinslvl10 = 0;
        PlayerController.coinslvl11 = 0;
        PlayerController.coinslvl12 = 0;
        PlayerController.coinslvl13 = 0;
        PlayerController.coinslvl14 = 0;
        PlayerController.coinslvl15 = 0;
        PlayerController.coinslvl16 = 0;
        PlayerController.coinslvl17 = 0;
        PlayerController.coinslvl18 = 0;
        PlayerController.coinslvl19 = 0;
        PlayerController.coinslvl20 = 0;
        SceneManager.LoadScene(0);
    }

}
