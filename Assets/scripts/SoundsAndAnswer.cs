// Eetu Rantakangas, 25.1.2014

using UnityEngine;
using System.Collections;

public class SoundsAndAnswer : MonoBehaviour {
	

	public AudioClip[] drunkPeopleSounds;
	public string[] Answers;
	private System.Random rnd = new System.Random();

	public int soitaAani(){
		int randomSound = rnd.Next(0, 2);
	//	checkAudioSource();
	//	audio.clip = drunkPeopleSounds[randomSound];
	//	audio.Play();
		return randomSound;
	}

	void checkAudioSource(){
		if(audio==null){
			gameObject.AddComponent<AudioSource>();
		}	
	}
	
	}

