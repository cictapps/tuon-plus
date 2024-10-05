using UnityEngine;
using UnityEngine.SceneManagement;

public class ToItem : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void ToItemScene()
    {
        SceneManager.LoadScene("QandA.Items");
    }
}