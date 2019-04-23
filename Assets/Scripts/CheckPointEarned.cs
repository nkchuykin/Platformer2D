using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointEarned : MonoBehaviour {

    BoxCollider2D myCollider,playerCollider;
    CircleCollider2D playerCircleColider;


    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        myCollider = GetComponent<BoxCollider2D>();
        playerCollider = player.GetComponent<BoxCollider2D>();
        playerCircleColider = player.GetComponent<CircleCollider2D>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (myCollider.IsTouching(playerCollider)|| myCollider.IsTouching(playerCircleColider))
        {
            CheckPointScript.cp = new CheckPoint(player.transform.localPosition);
            Destroy(gameObject);
        }
		
	}
}
