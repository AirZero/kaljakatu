//Based on Roboto game scripts

using UnityEngine;
using System.Collections;

public class GameOptionControl : MonoBehaviour {

	private SoundsAndAnswer sa;

	void update(){


	}
	

	// toimii buildin ekassa skenessä
	void Start() {
		sa = new SoundsAndAnswer();

	}

	public enum GameOptions{
		Level1,
		Level2,
		Level3,
		Level4,
		Level5,
		Level6,
		Level7
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
			Application.LoadLevel("tillintallin");
			break;
		case GameOptions.Level3:
	
			Application.LoadLevel("juoppo1");

			break;
		case GameOptions.Level4:
	
			Application.LoadLevel("kirkkopuisto");

			break;
		case GameOptions.Level5:
			Application.LoadLevel("vakkari");
		
			break;

	case GameOptions.Level7:
			int randomSound = 0;
			randomSound = sa.soitaAani();
			string choice = "tupakkaa";
//			Debug.Log();
			if(sa.Answers[randomSound]==choice){
			Application.LoadLevel("vakkari");
			}
			else
			Application.LoadLevel("tillintallin");

	//		string answer5 = "vakkari";
//			if(answer5 == soundAtm){
//			Application.LoadLevel(answer5);
	//		}
	//		else Application.LoadLevel("tillintallin");
			break;




		case GameOptions.Level6:
//			audio.clip = SoundsAndAnswer.olina;
//			audio.Play();
			break;
	/*	case GameOptions.Quit:
			Application.Quit();
			break;
*/			
		}


    }//OnMouseUp
}
