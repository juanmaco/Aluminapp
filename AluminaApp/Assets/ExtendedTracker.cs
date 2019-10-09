using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAR;

public class ExtendedTracker : MonoBehaviour {
	public GameObject Target;
	public GameObject ContainerTarget;
	bool detected = false;
	float timer = 0;
	public float timeActiveOnTargetLose = .5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Target.activeSelf == true) {
			detected = true;
			timer = 0f;
		} else {
			detected = false;	
		}
		if (Target.activeSelf == false && timer < timeActiveOnTargetLose) {
			ContainerTarget.transform.SetParent (this.transform);
			timer += Time.deltaTime;
		} else if(Target.activeSelf == false){
			ContainerTarget.transform.SetParent (Target.transform);
		}
	}
}
