using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour {

    public float speed = 0.1f;
    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
       gameObject.transform.Translate(speed,0,0);
	}

    void OnCollisionEnter2D (Collision2D col) {
        if (col.gameObject == player)
            player.GetComponent<DeathScript>().Death();
        Destroy(gameObject); 
    }
}
