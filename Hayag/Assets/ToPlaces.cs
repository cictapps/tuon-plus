using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPlaces : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void ToPlacesScene()
    {
        SceneManager.LoadScene("QandA.Places");
    }
}