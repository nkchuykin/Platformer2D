using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillHeroScript : MonoBehaviour {
    
    private GameObject player;

    private BoxCollider2D playerBoxCollider;
    private CircleCollider2D playerCircleCollider;
    private BoxCollider2D myCollider;

    DeathScript playerDeathScript;

	void Start () {
        player = GameObject.Find("Player");
        myCollider = GetComponent<BoxCollider2D>();
		playerBoxCollider = player.GetComponent<BoxCollider2D>();
        playerCircleCollider = player.GetComponent<CircleCollider2D>();
        playerDeathScript = player.GetComponent<DeathScript>();
	}

	void Update () {
		if (myCollider.IsTouching(playerBoxCollider)|| myCollider.IsTouching(playerCircleCollider))
        {
            playerDeathScript.Death();
        }
	}
}
