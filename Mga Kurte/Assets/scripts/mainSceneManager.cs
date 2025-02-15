using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainbuttons : MonoBehaviour
{
    
    public void GoToGameDirectory(){
        SceneManager.LoadScene("1 GameDirectory");
    }
    public void GoToMagtuon(){
        SceneManager.LoadScene("2.1 Magtuon");
    }

    public void GoToPahampang(){
        SceneManager.LoadScene("2.2 Pahampang");
    }
    public void GoToPaghasi(){
        SceneManager.LoadScene("2.3 Paghasi");
    }

    public void GoToHouse(){
        SceneManager.LoadScene("House");
    }

    public void GoToSea(){
        SceneManager.LoadScene("Sea");
    }

    public void GoToClassroom(){
        SceneManager.LoadScene("School");
    }
}

