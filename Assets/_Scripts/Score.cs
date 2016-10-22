using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public GameController gameController;

	private void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.CompareTag ("enemy")) {
			this.gameController.score += 10;
			Debug.Log("MONIS");
		}

	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
