using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    int coins = 0;

    [SerializeField] Text coinsText;
    [SerializeField] AudioSource coinSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "COINS: " + coins;
            coinSound.Play();
        }
    }
}
