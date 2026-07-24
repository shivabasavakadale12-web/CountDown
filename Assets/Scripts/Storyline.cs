using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Storyline : MonoBehaviour
{
    private const float Seconds = 3f;
    [SerializeField] TMP_Text story;
    [SerializeField] TMP_Text hook;
    [SerializeField] TMP_Text countdowntext;
    [SerializeField] TMP_Text letsgotext;

    string lineone = "objective: Survive till cops arrive";
    string linetwo = "Survive the waves of enemy";
    string linethree = "kill enemy so that your health stays full";
    string linefour = "You ready";
    string linefive = "Game starts in";
    string countdown = "3";
    string countdown2 = "2";
    string countdown3 = "1";
    string letsgo = "Let's goo";

    void Start()
    {
        StartCoroutine(readtext());
    }
  
    IEnumerator readtext()
    {
        story.text = lineone.ToString();
        yield return new WaitForSeconds(Seconds);

        story.text = linetwo.ToString();
        yield return new WaitForSeconds(Seconds);

        story.text = linethree.ToString();
        yield return new WaitForSeconds(Seconds);

        Destroy(story);
        hook.text = linefour.ToString();
        yield return new WaitForSeconds(Seconds);

        hook.text = linefive.ToString();
        yield return new WaitForSeconds(Seconds);

        Destroy(hook);
        countdowntext.text= countdown.ToString();
        yield return new WaitForSeconds(1f);

        countdowntext.text = countdown2.ToString();
        yield return new WaitForSeconds(1f);

        countdowntext.text = countdown3.ToString();
        yield return new WaitForSeconds(1f);

        Destroy(countdowntext);
        letsgotext.text = letsgo.ToString();
        yield return new WaitForSeconds(Seconds);

        SceneManager.LoadScene(2);

    }
}
