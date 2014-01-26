// Eetu Rantakangas, 25.1.2014

using UnityEngine;
using System.Collections;

public class SoundsAndAnswer : MonoBehaviour {
	

	public AudioClip[] drunkPeopleSounds = new AudioClip[3];
	public string[] Answers = {"rahaa", "tupakkaa", "kaljaa"};//new string[3];
	private System.Random rnd = new System.Random();
		
	//Answers[1] = "rahaa";



	void start() {
	}

	public int soitaAani(){
		int randomSound = rnd.Next(0, 3);
		checkAudioSource();
		audio.clip = drunkPeopleSounds[randomSound];
		audio.Play();
		Debug.Log(Answers[2]);
		return randomSound;
	}

	void checkAudioSource(){
		if(audio==null){
			gameObject.AddComponent<AudioSource>();
		}	
	}
	
	}

