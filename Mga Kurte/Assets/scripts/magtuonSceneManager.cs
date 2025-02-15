using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class magtuonSceneManager : MonoBehaviour
{
    public void GoToBilog(){
        SceneManager.LoadScene("1 Bilog");
    }

    public void GoToObalo(){
        SceneManager.LoadScene("2 Obalo");
    }

    public void GoToRektanggulo(){
        SceneManager.LoadScene("3 Rektanggulo");
    }

    public void GoToTrianggulo(){
        SceneManager.LoadScene("4 Trianggulo");
    }

    public void GoToBituon(){
        SceneManager.LoadScene("5 Bituon");
    }

    public void GoToKwadrado(){
        SceneManager.LoadScene("6 Kwadrado");
    }

    public void GoToPormaTagipusuon(){
        SceneManager.LoadScene("7 Porma Tagipusuon");
    }

    public void GoToDiamante(){
        SceneManager.LoadScene("8 Diamante");
    }
}
