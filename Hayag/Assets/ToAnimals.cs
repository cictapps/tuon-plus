using UnityEngine;
using UnityEngine.SceneManagement;

public class ToAnimals : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void ToAnimalScene()
    {
        SceneManager.LoadScene("QandA.Animals");
    }
}