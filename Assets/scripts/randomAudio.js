//

// play a random sound from a folder

//


var isPlaying : boolean = false;

var thisSound : AudioSource;

var myClips : Object[];


function Start(){

    myClips = Resources.LoadAll("sounds/juoppo1",AudioClip);

}

 

function OnTriggerEnter(){

    if(isPlaying == false){

        isPlaying = true;

        audio.clip = myClips[Random.Range(0, myClips.Length)];

        audio.Play();

    }

}

 

function OnTriggerExit(){

    if(isPlaying == true){

        isPlaying = false;

        audio.Stop();

    }

}