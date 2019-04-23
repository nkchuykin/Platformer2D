using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraScript : MonoBehaviour {

	public GameObject target;
    public Tilemap level;
    float time;
  


    private Camera camera;

    private float width;

    private void Start()
    {
        camera = GetComponent<Camera>();
        float height = 2f * camera.orthographicSize;
        width = height * camera.aspect;
    }

    // Update is called once per frame
    void Update () {

        camera.transform.localPosition = new Vector3(Mathf.Min(Mathf.Max(width/2-11f,target.transform.localPosition.x),level.size.x-width/2), 2.5f, -10);
       
		
	}
}
