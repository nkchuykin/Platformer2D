using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour {
    public int jumpForse;
    private CircleCollider2D ck;
    public Animator animator;

    private Collider2D tilemapCollider;
    public GameObject tilemap;

    // Use this for initialization
    void Start()
    {
        ck = GetComponent<CircleCollider2D>();
        tilemapCollider = tilemap.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetInteger("State") > 2)
            return;
        if(!ck.IsTouching(tilemapCollider))
        {
            animator.SetInteger("State", 2);
            return;
        }
        animator.SetBool("GameStarted", true);
        if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetInteger("State", 1);
            return;
        }
        animator.SetInteger("State", 0);
        return;
    }
}
