using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2AttackScript : MonoBehaviour {
    public float tmin = 5,tmax=10;
    private float t;
    private float currentTimeOffset; 

    public GameObject fireBallPrefab;

    private Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        if (tmax<tmin)
            tmax = tmin;
        currentTimeOffset = Random.Range(tmin,tmax);
		
	}
	
	// Update is called once per frame
	void Update () {
		t+=Time.deltaTime;
        if (t>currentTimeOffset)
        {
            t = 0;
            currentTimeOffset = Random.Range(tmin,tmax);
            animator.SetBool("fire",true);
            Invoke("fire",0.5f);
        }
	}

    void fire()
    {
        animator.SetBool("fire",false);
        Destroy(Instantiate(fireBallPrefab,gameObject.transform),2f);
    }
}
