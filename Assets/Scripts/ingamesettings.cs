using UnityEngine;

public class ingamesettings : MonoBehaviour
{

    [SerializeField] GameObject settings;

    bool settingson = false;
    public void gamemenu()
    {
        if (!settingson)
        {
            settings.SetActive(true);
            Time.timeScale = 0f;
            settingson = true;
        }
    }

    public void resume()
    {
        settings.SetActive(false);
        Time.timeScale = 1f;
    }
    public void quit()
    {
        Application.Quit();
    }

}
