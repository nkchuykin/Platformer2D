using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollideScript : MonoBehaviour {

    Text text;
    GameObject player;

    void Start()
    {
        text = GameObject.Find("Text").GetComponentInChildren<Text>();
        player = GameObject.Find("Player");
    }


	void OnCollisionEnter2D (Collision2D col) {
        if (col.gameObject == player)
        {
            text.text = (int.Parse(text.text)+1).ToString();
            Destroy(gameObject); 
        }
    }
}
