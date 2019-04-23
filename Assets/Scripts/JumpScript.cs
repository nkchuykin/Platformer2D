using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {
    private Rigidbody2D rb;
    public int jumpForse;
    private CircleCollider2D ck;

    private Collider2D tilemapCollider;
    public GameObject tilemap;

    // Use this for initialization
    void Start () { 
        rb = GetComponent<Rigidbody2D>();
        ck = GetComponent<CircleCollider2D>();
        tilemapCollider = tilemap.GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)&&ck.IsTouching(tilemapCollider))
            rb.AddForce(Vector2.up * jumpForse);
	}
}
