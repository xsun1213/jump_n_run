using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public PlayerController Player;

    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = Player.CoinCollected + "/";
    }
}
