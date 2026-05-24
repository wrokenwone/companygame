using UnityEngine;
using TMPro;

public class IntroText : MonoBehaviour
{
    public float charDelay = 0.05f;
    public float displayTime = 3f;
    public GameObject textBackground;
    private string fullText = "Bugün normal bir gün olacaktı.";
    private TextMeshProUGUI tmp;
    private float charTimer;
    private int currentChar;
    private bool typing = true;
    private float waitTimer;

    private void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
        tmp.text = "";
    }

    private void Update()
    {
        if (typing)
        {
            charTimer += Time.deltaTime;
            if (charTimer >= charDelay)
            {
                charTimer = 0;
                currentChar++;
                tmp.text = fullText.Substring(0, currentChar);
                if (currentChar >= fullText.Length)
                {
                    typing = false;
                    waitTimer = displayTime;
                }
            }
        }
        else
        {
            waitTimer -= Time.deltaTime;
            if (waitTimer <= 0)
            {
                textBackground.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
}