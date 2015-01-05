using UnityEngine;
using System.Collections;

public class Platform_Movement : MonoBehaviour {

	public Transform targetA;
	public Transform targetB;
	public float speed;
	public bool isActive = true;

	private Transform activeTarget;
	private bool isActiveTargetA;

	// Use this for initialization
	void Start () {
		transform.position = targetA.position;
		activeTarget = targetB;
		isActiveTargetA = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (isActive) {
				float step = speed * Time.deltaTime;
				transform.position = Vector3.MoveTowards (transform.position, activeTarget.position, step);
				if (transform.position == activeTarget.position) {
						if (isActiveTargetA) {
								activeTarget = targetB;
								isActiveTargetA = false;
						} else {
								activeTarget = targetA;
								isActiveTargetA = true;
						}
				}
		}
	}
}
