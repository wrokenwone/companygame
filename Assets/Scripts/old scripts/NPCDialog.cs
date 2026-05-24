using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCDialog : MonoBehaviour
{
    public GameObject dialogPanel;
    public GameObject ePrompt;
    private bool playerNearby = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
            ePrompt.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
            ePrompt.SetActive(false);
            dialogPanel.SetActive(false);
        }
    }

    private void Update()
    {
        if (playerNearby && Input.GetKeyDown(KeyCode.E))
        {
            dialogPanel.SetActive(true);
        }
    }

    public void Continue()
    {
        SceneManager.LoadScene("BossRoom");
    }
}