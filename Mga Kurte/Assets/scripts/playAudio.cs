using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio : MonoBehaviour
{
    public AudioSource soundPlayer;
    
    public void playVoiceOver(){
        soundPlayer.Play();
    }
}
