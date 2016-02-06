using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; // the target that the camera should look at
    public Vector3 CameraDisplacement = new Vector3(0, 0, -3);
    void Start() {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
		}
	}

	// Called when MouseDown on this gameObject
	void OnMouseDown () {
		// change the target of the LookAtTarget script to be this gameobject.
		LookAtTarget.target = target;
        //Camera.main.fieldOfView = 60*target.transform.localScale.x;
        Camera.main.transform.position = target.transform.position + CameraDisplacement * target.transform.localScale.x;
    }
}
