using UnityEngine;
using System.Collections;

// reference to the UI namespace
using UnityEngine.UI;

// reference to manage my scenes
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	// PRIVATE INSTANCE VARIABLES ++++++++++++++++++


	// PUBLIC INSTANCE VARIABLES
	public int tankCount;
	public GameObject tank;
	public Transform spawn;


	public bool dead = false;
	public uint score = 0;
	public int lives = 5;
	public Texture2D scoreIconTexture;
	public Texture2D lIconTexture;

	void OnGUI()
	{
		DisplayScoreCount();
		DisplayLCount ();
		DisplayRestartButton();
	}



	void DisplayLCount()
	{
		Rect coinIconRect = new Rect(10, 10, 32, 32);
		GUI.DrawTexture(coinIconRect, lIconTexture);                         

		GUIStyle style = new GUIStyle();
		style.fontSize = 30;
		style.fontStyle = FontStyle.Bold;
		style.normal.textColor = Color.yellow;

		Rect labelRect = new Rect(coinIconRect.xMax, coinIconRect.y, 60, 32);
		GUI.Label(labelRect, lives.ToString(), style);
	}

	void DisplayScoreCount()
	{
		Rect coinIconRect = new Rect(100, 10, 32, 32);
		GUI.DrawTexture(coinIconRect, scoreIconTexture);                         

		GUIStyle style = new GUIStyle();
		style.fontSize = 30;
		style.fontStyle = FontStyle.Bold;
		style.normal.textColor = Color.yellow;

		Rect labelRect = new Rect(coinIconRect.xMax, coinIconRect.y, 60, 32);
		GUI.Label(labelRect, score.ToString(), style);
	}

	void DisplayRestartButton()
	{
		if (dead)
		{
			Rect buttonRect = new Rect(Screen.width * 0.35f, Screen.height * 0.45f, Screen.width * 0.30f, Screen.height * 0.1f);
			if (GUI.Button(buttonRect, "Click to restart!"))
			{
				Application.LoadLevel (Application.loadedLevelName);
			};
		}
	}

	// Use this for initialization
	void Start () {

			this._GenerateTanks ();



	}
	
	// Update is called once per frame
	void Update () {
	
	}



	// generate Tanks
	private void _GenerateTanks() {

		///idk why doesnt it work, but it should theoreticaly stop spawning tanks after the player is dead

		if (!dead) {
			for (int count = 0; count < this.tankCount; count++) {
			
				Instantiate (tank, spawn);
			}
		}

		///I tried to avoid overlapping here and i almost did it with instantiating, 
		///but they still overlap if one tank is faster than the other one.
			/// i used a couple of things:
			/// 1. reseted tanks if they collided right after spawning and i moved the spawn area on top but 
			/// 	it caused tanks, that were overlapping on the map itself to reset aswell
			/// 2. tried to check on collisions at a place, where the tank would be instantiated but i failed 
			/// 	because of my lack of knowledge.
			/// 3. im not bright


	}





}
