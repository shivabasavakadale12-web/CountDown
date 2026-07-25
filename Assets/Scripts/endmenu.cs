using UnityEngine;
using UnityEngine.SceneManagement;

public class endmenu : MonoBehaviour
{
    
    public void restart()
    {
        SceneManager.LoadScene(1);
    }

    public void quit()
    {
        Application.Quit();
    }
}
