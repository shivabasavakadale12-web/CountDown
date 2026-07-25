using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    [SerializeField] TMP_Text timetext;
    float time = 120;

    void Update()
    {

        if (time > 0)
        {
            time -= Time.deltaTime;
            timetext.text = Mathf.Ceil(time).ToString("000");

        }

        if (time == 0)
        {
            time = 0;
            //game over logic here with ui wait for it tho hehe.
            //text of you survived and then buttons of play again and quit thats all 
        }
    }
}
