using UnityEngine;
using System.Collections;

public class Leaver_Action : MonoBehaviour {

	public GameObject actionObject;

	void OnTriggerStay2D(Collider2D collider) {
		if (collider.tag == "Player" && Input.GetKeyDown (KeyCode.E)) {
			Platform_Movement platformMovementObj = actionObject.GetComponent<Platform_Movement>();
			if(platformMovementObj.isActive) {
				platformMovementObj.isActive = false;
			} else {
				platformMovementObj.isActive = true;
			}
			// Multiply the player's x local scale by -1
			Vector2 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
		
	}
}
