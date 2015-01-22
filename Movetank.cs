using UnityEngine;
using System.Collections;

public class Movetank : MonoBehaviour {
    public float rotatiespeed = 8.5f;
    public float movespeed = 2f;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.W)){
			transform.Translate(Vector3.forward * movespeed);
        }
		if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.back * movespeed);
		}
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(Vector3.down * rotatiespeed);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(Vector3.up * rotatiespeed);
        }
	}
}
