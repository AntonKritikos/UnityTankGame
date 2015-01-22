using UnityEngine;
using System.Collections;

public class TargetPlayer : MonoBehaviour {
    public float reloadTime;
    public float Reloading;
    public float Range;
    private Transform turret;
    public GameObject bulletPrefab;
    private Transform nozzle;
	// Use this for initialization
    void Start()
    {
        reloadTime = 0;
        Transform[] transforms = this.gameObject.GetComponentsInChildren<Transform>();
        foreach (Transform t in transforms)
        {
            if (t.gameObject.name == "Turret")
            {
                turret = t;
            }
            if (t.gameObject.name == "Nozzle")
            {
                nozzle = t;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        reloadTime += Time.deltaTime;
        if(reloadTime >= Reloading)
        {
            checkForPlayer();
        }
	}
    private void checkForPlayer()
    {
        Ray myRay = new Ray();
        myRay.origin = turret.position;
        myRay.direction = turret.forward;
        RaycastHit hitting;
       if( Physics.Raycast(myRay,out hitting,Range))
       {
           string hitObject = hitting.collider.gameObject.name;
           if(hitObject == "Tank")
           {
               Instantiate(bulletPrefab, nozzle.transform.position, nozzle.rotation);
               reloadTime = 0;
           }
       }
    }
}
