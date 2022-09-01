using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTextController : MonoBehaviour
{
    public Text text;

    void Start()
    {
        if (PlayerController.coinslvl1 < PlayerPrefs.GetInt("lvl1"))
        {
            PlayerController.coinslvl1 = PlayerPrefs.GetInt("lvl1");
        }
        if (PlayerController.coinslvl2 < PlayerPrefs.GetInt("lvl2"))
        {
            PlayerController.coinslvl2 = PlayerPrefs.GetInt("lvl2");
        }
        if (PlayerController.coinslvl3 < PlayerPrefs.GetInt("lvl3"))
        {
            PlayerController.coinslvl3 = PlayerPrefs.GetInt("lvl3");
        }
        if (PlayerController.coinslvl4 < PlayerPrefs.GetInt("lvl4"))
        {
            PlayerController.coinslvl4 = PlayerPrefs.GetInt("lvl4");
        }
        if (PlayerController.coinslvl5 < PlayerPrefs.GetInt("lvl5"))
        {
            PlayerController.coinslvl5 = PlayerPrefs.GetInt("lvl5");
        }
        if (PlayerController.coinslvl6 < PlayerPrefs.GetInt("lvl6"))
        {
            PlayerController.coinslvl6 = PlayerPrefs.GetInt("lvl6");
        }
        if (PlayerController.coinslvl7 < PlayerPrefs.GetInt("lvl7"))
        {
            PlayerController.coinslvl7 = PlayerPrefs.GetInt("lvl7");
        }
        if (PlayerController.coinslvl8 < PlayerPrefs.GetInt("lvl8"))
        {
            PlayerController.coinslvl8 = PlayerPrefs.GetInt("lvl8");
        }
        if (PlayerController.coinslvl9 < PlayerPrefs.GetInt("lvl9"))
        {
            PlayerController.coinslvl9 = PlayerPrefs.GetInt("lvl9");
        }
        if (PlayerController.coinslvl10 < PlayerPrefs.GetInt("lvl10"))
        {
            PlayerController.coinslvl10 = PlayerPrefs.GetInt("lvl10");
        }
        if (PlayerController.coinslvl11 < PlayerPrefs.GetInt("lvl11"))
        {
            PlayerController.coinslvl11 = PlayerPrefs.GetInt("lvl11");
        }
        if (PlayerController.coinslvl12 < PlayerPrefs.GetInt("lvl12"))
        {
            PlayerController.coinslvl12 = PlayerPrefs.GetInt("lvl12");
        }
        if (PlayerController.coinslvl13 < PlayerPrefs.GetInt("lvl13"))
        {
            PlayerController.coinslvl13 = PlayerPrefs.GetInt("lvl13");
        }
        if (PlayerController.coinslvl14 < PlayerPrefs.GetInt("lvl14"))
        {
            PlayerController.coinslvl14 = PlayerPrefs.GetInt("lvl14");
        }
        if (PlayerController.coinslvl15 < PlayerPrefs.GetInt("lvl15"))
        {
            PlayerController.coinslvl15 = PlayerPrefs.GetInt("lvl15");
        }
        if (PlayerController.coinslvl17 < PlayerPrefs.GetInt("lvl17"))
        {
            PlayerController.coinslvl17 = PlayerPrefs.GetInt("lvl17");
        }
        if (PlayerController.coinslvl18 < PlayerPrefs.GetInt("lvl18"))
        {
            PlayerController.coinslvl18 = PlayerPrefs.GetInt("lvl18");
        }
        if (PlayerController.coinslvl19 < PlayerPrefs.GetInt("lvl19"))
        {
            PlayerController.coinslvl19 = PlayerPrefs.GetInt("lvl19");
        }
        if (PlayerController.coinslvl20 < PlayerPrefs.GetInt("lvl20"))
        {
            PlayerController.coinslvl20 = PlayerPrefs.GetInt("lvl20");
        }
        if (PlayerController.coinslvl16 < PlayerPrefs.GetInt("lvl16"))
        {
            PlayerController.coinslvl16 = PlayerPrefs.GetInt("lvl16");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Textlvl1")
        {
            
            text.text = "lvl 1 | " + PlayerController.coinslvl1 + "/ 42";
            PlayerPrefs.SetInt("lvl1", PlayerController.coinslvl1);
            PlayerPrefs.Save();

        }
        if (gameObject.name == "Textlvl2")
        {
            text.text = "lvl 2 | " + PlayerController.coinslvl2 + "/ 57";
            PlayerPrefs.SetInt("lvl2", PlayerController.coinslvl2);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl3")
        {
            text.text = "lvl 3 | " + PlayerController.coinslvl3 + "/ 79";
            PlayerPrefs.SetInt("lvl3", PlayerController.coinslvl3);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl4")
        {
            text.text = "lvl 4 | " + PlayerController.coinslvl4 + "/ 136";
            PlayerPrefs.SetInt("lvl4", PlayerController.coinslvl4);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl5")
        {
            text.text = "lvl 5 | " + PlayerController.coinslvl5 + "/ 68";
            PlayerPrefs.SetInt("lvl5", PlayerController.coinslvl5);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl6")
        {
            text.text = "lvl 6 | " + PlayerController.coinslvl6 + "/ 32";
            PlayerPrefs.SetInt("lvl6", PlayerController.coinslvl6);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl7")
        {
            text.text = "lvl 7 | " + PlayerController.coinslvl7 + "/ 110";
            PlayerPrefs.SetInt("lvl7", PlayerController.coinslvl7);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl8")
        {
            text.text = "lvl 8 | " + PlayerController.coinslvl8 + "/ 86";
            PlayerPrefs.SetInt("lvl8", PlayerController.coinslvl8);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl9")
        {
            text.text = "lvl 9 | " + PlayerController.coinslvl9 + "/ 80";
            PlayerPrefs.SetInt("lvl9", PlayerController.coinslvl9);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl10")
        {
            text.text = "lvl 10 | " + PlayerController.coinslvl10 + "/ 179";
            PlayerPrefs.SetInt("lvl10", PlayerController.coinslvl10);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl11")
        {
            text.text = "lvl 11 | " + PlayerController.coinslvl11 + "/ 75";
            PlayerPrefs.SetInt("lvl11", PlayerController.coinslvl11);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl12")
        {
            text.text = "lvl 12 | " + PlayerController.coinslvl12 + "/ 0";
            PlayerPrefs.SetInt("lvl12", PlayerController.coinslvl12);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl13")
        {
            text.text = "lvl 13 | " + PlayerController.coinslvl13 + "/ 88";
            PlayerPrefs.SetInt("lvl13", PlayerController.coinslvl13);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl14")
        {
            text.text = "lvl 14 | " + PlayerController.coinslvl14 + "/ 63";
            PlayerPrefs.SetInt("lvl14", PlayerController.coinslvl14);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl15")
        {
            text.text = "lvl 15 | " + PlayerController.coinslvl15 + "/ 123";
            PlayerPrefs.SetInt("lvl15", PlayerController.coinslvl15);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl16")
        {
            text.text = "lvl 16 | " + PlayerController.coinslvl16 + "/ 123";
            PlayerPrefs.SetInt("lvl16", PlayerController.coinslvl16);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl17")
        {
            text.text = "lvl 17 | " + PlayerController.coinslvl17 + "/ 123";
            PlayerPrefs.SetInt("lvl17", PlayerController.coinslvl17);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl18")
        {
            text.text = "lvl 18 | " + PlayerController.coinslvl18 + "/ 123";
            PlayerPrefs.SetInt("lvl18", PlayerController.coinslvl18);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl19")
        {
            text.text = "lvl 19 | " + PlayerController.coinslvl19 + "/ 123";
            PlayerPrefs.SetInt("lvl19", PlayerController.coinslvl19);
            PlayerPrefs.Save();
        }
        if (gameObject.name == "Textlvl20")
        {
            text.text = "lvl 20 | " + PlayerController.coinslvl20 + "/ 0";
            PlayerPrefs.SetInt("lvl20", PlayerController.coinslvl20);
            PlayerPrefs.Save();
        }

        if (gameObject.name == "TextAll")
        {
            text.text = PlayerController.coinslvl1 + PlayerController.coinslvl2 + PlayerController.coinslvl3 + PlayerController.coinslvl4 + PlayerController.coinslvl5 + PlayerController.coinslvl6 + PlayerController.coinslvl7 + PlayerController.coinslvl8 + PlayerController.coinslvl9 + PlayerController.coinslvl10 + PlayerController.coinslvl11 + PlayerController.coinslvl12 + PlayerController.coinslvl13 + PlayerController.coinslvl14 + PlayerController.coinslvl15 + PlayerController.coinslvl16 + PlayerController.coinslvl17 + PlayerController.coinslvl18 + PlayerController.coinslvl19 + PlayerController.coinslvl20 + "/ 1341";
            
        }


    }
}
