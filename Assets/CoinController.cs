using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public PlayerController Player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Player.CoinSound();
        }
    }

    private void OnDestroy()
    {
        
        Player.CoinCollected++;
    }
}