using UnityEngine;
using System.Collections;

public class RotateTurret : MonoBehaviour {

    private Transform[] transforms;
    protected Transform turret;
    protected Vector3 targetPos;
    protected Transform nozzle;
    // Use this for initialization
    protected virtual void Start()
    {
        transforms = gameObject.GetComponentsInChildren<Transform>();
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
	protected virtual void Update () {
        turret.LookAt( targetPos);
	}
}
