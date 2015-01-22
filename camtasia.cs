using UnityEngine;
using System.Collections;

public class camtasia : MonoBehaviour {
    public Vector3 MyPos;
    public Transform MyPlay;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (MyPlay != null)
        {
            transform.position = MyPlay.position + MyPos;
        }
	}
}
