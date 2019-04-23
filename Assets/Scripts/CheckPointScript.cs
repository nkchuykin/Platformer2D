using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CheckPointScript : MonoBehaviour {

    public static bool flag = false;

    

    public static CheckPoint cp;

	// Use this for initialization
	void Start () {
		cp = new CheckPoint(transform.localPosition);
	}
	
	// Update is called once per frame
	void Update () {

		if (flag)
        { 
            flag = false;
            transform.localPosition = cp.GetLocation();
        }
	}
}
