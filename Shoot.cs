using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    public GameObject bulletPrefab;
    private GameObject turret;
    private GameObject nozzle;
    public float reloadTime;
    public float Reloading;
	// Use this for initialization
	void Start () {
	    Transform[] transforms = GetComponentsInChildren<Transform>();
        foreach(Transform t in transforms)
        {
            if(t.gameObject.name == "Turret")
            {
                turret = t.gameObject;
            }
            if (t.gameObject.name == "Nozzle")
            {
                nozzle = t.gameObject;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        reloadTime += Time.deltaTime;
	if(Input.GetButtonDown("Fire1") && reloadTime >= Reloading)
    {
        Quaternion rotation = Quaternion.Euler(Vector3.up * turret.transform.rotation.eulerAngles.y);
        Instantiate(bulletPrefab, nozzle.transform.position, rotation);
        reloadTime = 0;
    }
	}
}
