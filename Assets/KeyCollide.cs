using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollide : MonoBehaviour {

    public GameObject door;
    private Animator animator;
    GameObject player;
	// Use this for initialization
	void Start () {
        animator = door.GetComponent<Animator>();
	    player = GameObject.Find("Player");
	}
	
	void OnCollisionEnter2D (Collision2D col) {
        if (col.gameObject == player)
        {
            LevelCompleteScript.doorOpened = true;
            animator.SetBool("KeyFinded",true);
            Destroy(gameObject); 
        }
    }
}
