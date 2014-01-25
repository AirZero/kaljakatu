using UnityEngine;
using System.Collections;

public class SoundLoader : MonoBehaviour {
	public AudioClip[] menuSound;
	void Start () {
		menuSound = new AudioClip[]{
			Resources.Load("tupakkaa") as AudioClip,
			Resources.Load("charge") as AudioClip,
			Resources.Load("Armor") as AudioClip



		};
		//AudioSource.PlayClipAtPoint(menuSound[2],Vector3.zero);
	}
}