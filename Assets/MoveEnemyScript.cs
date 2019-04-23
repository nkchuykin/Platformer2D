using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyScript : MonoBehaviour {

    //Start moving from b to a
    public float B, A;
    private float position;
    private int direction = -1;

    public float speed = 3f;

    private float timer;
    private float deltaT=0.05f;
    
    void Start ()
    {
        position = B;
        Vector3 loc =gameObject.transform.localPosition;
        loc.x= B;
        gameObject.transform.position = loc;
    }

	// move enemy every deltaT seconds
	void Update () {
        timer += Time.deltaTime;
        if (timer>deltaT)
        {
            timer = 0;
            moveEnemy();
        }
	}

    void moveEnemy()
    {
        position += direction*speed;
        gameObject.transform.Translate(direction*speed,0,0);
        if (position<A||position>B)
        {
            direction *= -1;
            gameObject.transform.localScale = new Vector3(-direction*5,5,5);
        }
    }

}
