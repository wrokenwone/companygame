using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BossDialog : MonoBehaviour
{
    public GameObject dialogPanel;
    public TextMeshProUGUI dialogText;
    public string[] lines = {
        "Seni değerlendirdik...",
        "Fazla... normalsin.",
        "Bu şirkette bu kabul edilemez.",
        "Dün sadece 1 kez iç geçirdin.",
        "Enerjin çok stabil.",
        "KOVULDUN."
    };
    private int currentLine = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialogPanel.SetActive(true);
            dialogText.text = lines[currentLine];
        }
    }

    public void NextLine()
    {
        currentLine++;
        if (currentLine < lines.Length)
        {
            dialogText.text = lines[currentLine];
        }
        else
        {
            SceneManager.LoadScene("Fired");
        }
    }
}