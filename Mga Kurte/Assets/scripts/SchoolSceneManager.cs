using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SchoolSceneManager : MonoBehaviour
{
 public void BackButton(){
        SceneManager.LoadScene("2.2 Pahampang");
    }

 public void Maumpisa(){
        SceneManager.LoadScene("School 1");
    }

public void OneBack(){
        SceneManager.LoadScene("School");
    }

public void OneNext(){
        SceneManager.LoadScene("School 2");
    }
public void TwoBack(){
        SceneManager.LoadScene("School 1");
    }
public void TwoNext(){
        SceneManager.LoadScene("School 3");
    }

public void ThreeBack(){
        SceneManager.LoadScene("School 2");
    }
public void ThreeNext(){
        SceneManager.LoadScene("School 4");
    }

public void FourBack(){
        SceneManager.LoadScene("School 3");
    }
public void FourNext(){
        SceneManager.LoadScene("School 5");
    }

public void FiveBack(){
        SceneManager.LoadScene("School 4");
    }
public void FiveNext(){
        SceneManager.LoadScene("School 6");
    }

    public void SixBack(){
        SceneManager.LoadScene("School 5");
    }
public void SixNext(){
        SceneManager.LoadScene("School 7");
    }

public void SevenBack(){
        SceneManager.LoadScene("School 6");
    }
public void SevenNext(){
        SceneManager.LoadScene("School 8");
    }

public void EightBack(){
        SceneManager.LoadScene("School 7");
    }
public void EightNext(){
        SceneManager.LoadScene("School 9");
    }

    public void NineBack(){
        SceneManager.LoadScene("School 7");
    }

}
