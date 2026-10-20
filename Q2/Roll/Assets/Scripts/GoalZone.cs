using UnityEngine;

public class GoalZone : MonoBehaviour
{
    public GameObject winText;

    private bool won;

    private void OnTriggerEnter(Collider other)
    {
        if (won || !other.CompareTag("Player"))
            return;

        won = true;
        winText.SetActive(true);
        other.gameObject.SetActive(false);
    }
}