using UnityEngine;
using System.Collections;

public class PlayerColliderScript : MonoBehaviour {
	
	public GameController gameController;

	private void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.CompareTag ("enemy")) {
			this.gameController.lives -= 1;
			Debug.Log("ananas");
		}


		if (this.gameController.lives == 0) {
			this.gameController.dead = true;
			Debug.Log("you dieded");
		}

	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
