using PlasticGui.Configuration;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void changeScene()
    {
        SceneManager.LoadScene("BasicScene");
    }
}
