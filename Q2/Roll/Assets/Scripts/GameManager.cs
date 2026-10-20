using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject powerUp;
    public TMP_Text powerUpText;

    private int remainingCollectibles;

    private void Awake()
    {
        remainingCollectibles = FindObjectsByType<Collectible>(
            FindObjectsSortMode.None).Length;

        powerUp.SetActive(false);
        powerUpText.text = "";
    }

    public void CollectCube()
    {
        remainingCollectibles--;

        if (remainingCollectibles == 0)
            powerUp.SetActive(true);
    }

    public void ShowPowerUpActive()
    {
        powerUpText.text = "Power-up Active!";
    }
}