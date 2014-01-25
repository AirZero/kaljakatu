// Eetu Rantakangas, 25.1.2014

using UnityEngine;
using System.Collections;

public class SoundsAndAnswer : GameOptionControl {


	string rightAnswer = "Level1";


	//new Sounds: AudioClip[]{tupakkaa, kaljaa}; // set the array size and fill the elements with the sounds
//AudioClip[] sounds = new AudioClip[2] {tupakkaa, kaljaa};
/*	public void PlayRandom(){ // call this function to play a random sound
		if (audio.isPlaying) return; // don't play a new sound while the last hasn't finished
		audio.clip = sounds[Random.Range(0,sounds.length)];
		audio.Play();
	}

	*/
	//new AudioClip[] {tupakkaa, kaljaa};

	//public static AudioClip olina(){
//		return tupakkaa;
	//}



	




	//Kenttä 1 on randomSoundsPerlevel[0,randomSound]
	//string[,] randomSoundsPerlevel = {{ "tillintallin", "juoppo1", "kirkkopuisto", "vakkari" }, {"", "", ""}};

//	static string[][,] randomSounds = new string[2][] 
//	{
		//new string[,] { {"aani1.wav","aani2.wav", "aani2.wav"}, {"correct","fail","fail"} },
	//	new AudioClip[] {tupakkaa, kaljaa},// {"4","6"}, {"8", "10"} },
	//	new string[] {1,0}
		//new string[,] { {"0","2"}, {"4","6"}, {"8", "10"} } 
//	};
//
	public string Answer() {
		return rightAnswer;
	}

	// Soittaa äänen ja merkitsee oikean vastauksen.
	public static void PlayRandom(int levelNumber){
		System.Random rnd = new System.Random();
		int randomSound = rnd.Next(0, 1);
//		string answer = randomSounds[levelNumber][randomSound];
//		Play(randomSounds[levelNumber][randomSound]);
		//System.Console.Write(answer);
	//	jaggedArray4[0][1, 0]

		string rightAnswer = "Level1";

	}



}
