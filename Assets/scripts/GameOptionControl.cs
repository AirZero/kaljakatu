//Based on Roboto game scripts

using UnityEngine;
using System.Collections;

public class GameOptionControl : MonoBehaviour {

	//private SoundsAndAnswer sa;
	private SoundsAndAnswer sa;

	private System.Random rnd = new System.Random();


	void update(){
	}
	

	// toimii buildin ekassa skenessä
	void Start() {
	//	sa = new SoundsAndAnswer();
	

	//	sa = gameObject.AddComponent("SoundsAndAnswer") as SoundsAndAnswer;

		sa = GameObject.Find("Sounds").GetComponent<SoundsAndAnswer>();

		
		sa.kentta ();
	}
	
	public enum GameOptions{
		Level1,
		Level2,
		Level3,
		Level4,
		Level5,
		Level6,
		rahaa,
		tupakkaa,
		kaljaa
	//	Quit
	}
	
	public GameOptions gameOption;
	
	/**
	 * Changes the texts color to red, when there's cursor 
	 */
	void OnMouseEnter() {
    	//renderer.material.color = Color.green;
    }//OnMouseEnter
	
	
	/**
	 * Changes the texts color to white, when there's no cursor  
	 */
	void OnMouseExit() {
        //renderer.material.color = Color.white;
		//renderer.material.color = Color.black;//new Color(60.0f, 48.0f, 52.0f, 255.0f);
    }//OnMouseExit
	
	/**
	 * Event handler for mouse click 
	 */
	/*  --------------  int soitaAani(){
		System.Random rnd = new System.Random();
		int randomSound = rnd.Next(0, 4);
		checkAudioSource();
		audio.clip = drunkPeopleSounds[randomSound];
		audio.Play();	
		return randomSound;
	}

	*/




	void OnLevelWasLoaded() {

		
	}


		
		
		void OnMouseUp() {
    	/*
		//Checks wheter user chose New Game, Options or Quit
		if(isNewGame){
			Vector3 newPosition = new Vector3(30.0f,1.0f,-10.0f); 
			GameObject.Find("Main Camera").transform.position = newPosition;
		}else if(isMechanics){
			Application.LoadLevel(0); //level id in build settings
		}else if(isTank){
			Application.LoadLevel(1); //level id in build settings
		}else if(isOptions){
			//starts options
			Debug.Log("Options pressed");
		}else if(isQuit){
			//quits the application
			Application.Quit();
		}else{
			//Do nothing
		}
		*/
		switch(gameOption){
		case GameOptions.Level1:
			//audio.Play();
			renderer.material.color = Color.red;

			//Application.LoadLevel("02_level_01");
			//Application.LoadLevel();
			break;
		case GameOptions.Level2:
			sa.vaihdaKentta("tillintallin");

			break;
		case GameOptions.Level3:
			sa.vaihdaKentta("juoppo1");
	
			break;
		case GameOptions.Level4:
			sa.vaihdaKentta("kirkkopuisto");

			break;
		case GameOptions.Level5:
			sa.vaihdaKentta("vakkari");
		
			break;

	
	case GameOptions.rahaa:
		//	kentta();
			string choice = "rahaa";

//			Debug.Log(vastaus.CompareTo(choice) == 0);
			Debug.Log ("choise:" + choice);
		//	Debug.Log ("v:" + vastaus);

			//Debug.Log(sa.Answers[randomSound]);
			//Debug.Log("valinta");
		
			if(sa.vastaus.CompareTo(choice) == 0 ){
			sa.vaihdaKentta("kirkkopuisto");
			}
			else
			sa.vaihdaKentta("tillintallin");
			break;

		case GameOptions.tupakkaa:
	//		kentta();
			string choice2 = "tupakkaa";

			Debug.Log(sa.vastaus.CompareTo(choice2) == 0);
			Debug.Log ("choise:" + choice2);
			Debug.Log ("v:" + sa.vastaus);

			//Debug.Log(vastaus);
			if(sa.vastaus.CompareTo(choice2) == 0 ){
				sa.vaihdaKentta("kirkkopuisto");
			}
			else
				sa.vaihdaKentta("tillintallin");
			break;

		case GameOptions.kaljaa:
		//	kentta();
			string choice3 = "kaljaa";

			//Debug.Log(vastaus.CompareTo(choice3) == 0);
			Debug.Log ("choise:" + choice3);
			//Debug.Log ("v:" + vastaus);

			if(sa.vastaus.CompareTo(choice3) == 0 ){
				sa.vaihdaKentta("kirkkopuisto");
			}
			else
				sa.vaihdaKentta("tillintallin");
			break;
			//		string answer5 = "vakkari";
//			if(answer5 == soundAtm){
//			Application.LoadLevel(answer5);
	//		}
	//		else Application.LoadLevel("tillintallin");
	


			}


		//case GameOptions.Level6:
//			audio.clip = SoundsAndAnswer.olina;
//			audio.Play();
			//break;
	/*	case GameOptions.Quit:
			Application.Quit();
			break;
*/			


    }//OnMouseUp
}
