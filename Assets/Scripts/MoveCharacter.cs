using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D bk;

    public int hSpeed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            gameObject.transform.rotation = new Quaternion(0, 180, 0, 0);
        if (Input.GetKeyDown(KeyCode.RightArrow))
            gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);

        Vector2 newLocation = new Vector2(gameObject.transform.position.x + x * hSpeed, gameObject.transform.position.y);
        rb.MovePosition(newLocation);



    }
}
