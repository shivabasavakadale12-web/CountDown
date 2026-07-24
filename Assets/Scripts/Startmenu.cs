using UnityEngine;
using UnityEngine.SceneManagement;
public class Startmenu : MonoBehaviour
{

    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void quit()
    {
        Application.Quit();
    }
}
