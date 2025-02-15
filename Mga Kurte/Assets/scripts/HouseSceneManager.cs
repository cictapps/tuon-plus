using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassroomSceneManager : MonoBehaviour
{
 public void BackButton(){
        SceneManager.LoadScene("2.2 Pahampang");
    }

 public void Maumpisa(){
        SceneManager.LoadScene("House 1");
    }

public void OneBack(){
        SceneManager.LoadScene("House");
    }

public void OneNext(){
        SceneManager.LoadScene("House 2");
    }
public void TwoBack(){
        SceneManager.LoadScene("House 1");
    }
public void TwoNext(){
        SceneManager.LoadScene("House 3");
    }

public void ThreeBack(){
        SceneManager.LoadScene("House 2");
    }
public void ThreeNext(){
        SceneManager.LoadScene("House 4");
    }

public void FourBack(){
        SceneManager.LoadScene("House 3");
    }
public void FourNext(){
        SceneManager.LoadScene("House 5");

    }

    public void FiveBack(){
        SceneManager.LoadScene("House 4");
    }

}
