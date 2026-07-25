using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    } 
}
