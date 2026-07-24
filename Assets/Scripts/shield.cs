using UnityEngine;

public class shield : MonoBehaviour
{
    const string player = "Player";

    public bool isshield = false;

    public static shield instance;

     void Awake()
    {
        instance = this;
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == player)
        {
            isshield = true;
            gameObject.SetActive(false);
            Invoke("Waitfor", 8f);
        }


    }

    void Waitfor()
    {
        isshield = false;
    }
}
