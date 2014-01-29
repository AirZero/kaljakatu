// Eetu Rantakangas, 25.1.2014

using UnityEngine;
using System.Collections;

public class SoundsAndAnswer : MonoBehaviour {
	
	public string vastaus = "";
	public GameObject[] drunkPeopleSounds = new GameObject[3];
	public string[] Answers = {"rahaa", "tupakkaa", "kaljaa"};//new string[3];
	private System.Random rnd = new System.Random();
		
	//Answers[1] = "rahaa";



	void start() {
	}

	public int soitaAani(){
		
//		Debug.Log(drunkPeopleSounds);
		int randomSound = rnd.Next(0, 3);
		drunkPeopleSounds[randomSound].audio.Play();
		//checkAudioSource();

//		audio.clip = drunkPeopleSounds[randomSound];
//		audio.Play();
	//	Debug.Log("tas pitas lukee: tupakkaa" + Answers[1]);
		return randomSound;
	}

	public string rightAnswer(int answerNumber){
		return Answers[answerNumber];
	}

	void checkAudioSource(){
		if(audio==null){
			gameObject.AddComponent<AudioSource>();
		}	
	}

	public void vaihdaKentta(string kentanNimi){
		Application.LoadLevel(kentanNimi);
		kentta ();
	}

	public void kentta(){
		int randomSound = 0;
		//	sa.soitaAani();
		randomSound = soitaAani();
		//	Debug.Log("ennen" + vastaus);
		//	vastaus = sa.Answers[randomSound];
		vastaus = rightAnswer(randomSound);
		//	Debug.Log("jalkeen " + vastaus);
		//	Debug.Log(vastaus);
	}
	
	}

