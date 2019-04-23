using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompleteScript : MonoBehaviour {
    static internal bool doorOpened = false;
    GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void OnCollisionEnter2D (Collision2D col) {
        if (col.gameObject == player && doorOpened)
        {
            GameObject.Find("WINMSG").GetComponent<Text>().text = "YOU WIN!!!";
            player.GetComponent<Animator>().SetInteger("State", 4);
            Destroy(gameObject);
        }
    }
}
