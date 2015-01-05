using UnityEngine;
using System.Collections;

public class Player_Spawn : MonoBehaviour {
	public GameObject playerPrefab;

	// Use this for initialization
	void Start () {
		spawnCharacter ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public GameObject spawnCharacter() {
		GameObject player = (GameObject)Instantiate (playerPrefab, transform.position, Quaternion.identity);
		Camera.main.transform.parent = player.transform;
		Camera.main.transform.localPosition = new Vector3 (3f, 2f, -10f);
		Camera.main.orthographicSize = 3;
		return player;

	}
}
