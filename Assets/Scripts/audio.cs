using UnityEngine;

public class audio : MonoBehaviour
{
    [SerializeField] AudioSource sound;

    public bool ismute = false;
    public void ToggleSound()
    {
        if (ismute)
        {
          sound.Play();
            ismute = !ismute;
        }

        else
        {
            sound.Stop();
            ismute = true;
        }
    }
    
    

}
