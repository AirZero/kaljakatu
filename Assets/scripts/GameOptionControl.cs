//Based on Roboto game scripts

using UnityEngine;
using System.Collections;

public class GameOptionControl : MonoBehaviour {

	public AudioClip tupakkaa, kaljaa;
	static int levelNumber = 1;

	//Tarkistaa oikean vastauksen, kutsutaan tämän tyyppisissä aliohjelmissa: GameOptions.Level3
	void CheckAnswer() {

	}

	public static void increaseLevel(){
		levelNumber = levelNumber++;
	}

	
	void checkAudioSource(){
		if(audio==null){
			gameObject.AddComponent<AudioSource>();
		}
		
	}

	void update(){
	
	}

	void startLevel(){
		if(levelNumber == 1){
			checkAudioSource();
			audio.clip = tupakkaa;
			audio.Play();
		}
		
		if(levelNumber == 2){
			Application.LoadLevel("kirkkopuisto");
			audio.clip = kaljaa;
			audio.Play();
		}
	}

	// toimii buildin ekassa skenessä
	void Start() {
		startLevel();

	}

	public enum GameOptions{
		Level1,
		Level2,
		Level3,
		Level4,
		Level5,
		Level6
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
			startLevel();
			Application.LoadLevel("juoppo1");

			break;
		case GameOptions.Level4:
			increaseLevel();
			Application.LoadLevel("kirkkopuisto");
			startLevel();
			break;
		case GameOptions.Level5:
			Application.LoadLevel("vakkari");
		
			break;

			/*

	case GameOptions.Level5:
			string answer5 = "vakkari";
			if(answer5 == soundAtm){
			Application.LoadLevel(answer5);
			}
			else Application.LoadLevel("tillintallin");
			break;

*/


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
