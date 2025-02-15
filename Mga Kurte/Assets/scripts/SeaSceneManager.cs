using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeaSceneManager : MonoBehaviour
{
 public void BackButton(){
        SceneManager.LoadScene("2.2 Pahampang");
    }

 public void Maumpisa(){
        SceneManager.LoadScene("Sea 1");
    }

public void OneBack(){
        SceneManager.LoadScene("Sea");
    }

public void OneNext(){
        SceneManager.LoadScene("Sea 2");
    }
public void TwoBack(){
        SceneManager.LoadScene("Sea 1");
    }
public void TwoNext(){
        SceneManager.LoadScene("Sea 3");
    }

public void ThreeBack(){
        SceneManager.LoadScene("Sea 2");
    }
public void ThreeNext(){
        SceneManager.LoadScene("Sea 4");
    }

public void FourBack(){
        SceneManager.LoadScene("Sea 3");
    }
public void FourNext(){
        SceneManager.LoadScene("Sea 5");

    }

    public void FiveBack(){
        SceneManager.LoadScene("Sea 4");
    }

}
