using UnityEngine;
using UnityEngine.SceneManagement;

public class GlitchEffect : MonoBehaviour
{
    public GameObject glitchRed;
    public GameObject glitchBlue;
    public GameObject glitchWhite;
    private float timer;
    private float glitchTimer;
    private float totalTime = 3f;

    private void Start()
    {
        timer = totalTime;
        glitchTimer = 0.1f;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        glitchTimer -= Time.deltaTime;

        if (glitchTimer <= 0)
        {
            glitchTimer = Random.Range(0.05f, 0.2f);
            glitchRed.SetActive(Random.value > 0.5f);
            glitchBlue.SetActive(Random.value > 0.5f);
            glitchWhite.SetActive(Random.value > 0.7f);

            glitchRed.GetComponent<RectTransform>().anchoredPosition = 
                new Vector2(Random.Range(-50f, 50f), Random.Range(-50f, 50f));
            glitchBlue.GetComponent<RectTransform>().anchoredPosition = 
                new Vector2(Random.Range(-50f, 50f), Random.Range(-50f, 50f));
        }

        if (timer <= 0)
        {
            SceneManager.LoadScene("HomeWakeup");
        }
    }
}