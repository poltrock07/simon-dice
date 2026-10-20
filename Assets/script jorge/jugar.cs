using UnityEngine;
using UnityEngine.SceneManagement;

public class portada : MonoBehaviour
{
    public void jugar()
    {
        SceneManager.LoadScene("jorge");
    }
    public void salir()
    {
        Application.Quit();
    }
}
