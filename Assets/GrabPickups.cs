using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrabPickups : MonoBehaviour {

	private AudioSource pickupSoundSource;
	public static int numberOfPickups = 1;
	void Awake() {
		pickupSoundSource = DontDestroy.instance.GetComponents<AudioSource>()[1];
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.gameObject.tag == "Pickup") {
			numberOfPickups++;
			pickupSoundSource.Play();
			SceneManager.LoadScene("Play");
		}
	}
	public static void resetPickups() {
		numberOfPickups = 1;
	}
}
