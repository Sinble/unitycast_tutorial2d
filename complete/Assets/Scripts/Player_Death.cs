using UnityEngine;
using System.Collections;

public class Player_Death : MonoBehaviour {
	
	void OnTriggerStay2D(Collider2D collider) {
		if (collider.tag == "Player") {
			Player_Spawn plrSpwn = (Player_Spawn)GameObject.Find("PlayerSpawn").GetComponent<Player_Spawn>();
			plrSpwn.spawnCharacter();
			Destroy (collider.gameObject);

		}				
	}
}
