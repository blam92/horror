using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Text))]
public class MazeText : MonoBehaviour {
	private Text text;
	private int level;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		text.text = "Maze: " + GrabPickups.numberOfPickups;
	}
}
