using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speedMultiplier = 2f;
    public Color powerUpColor = Color.red;

    private bool collected;

    public Renderer specialWallRenderer;
    public Color wallPowerUpColor = Color.red;

    private void OnTriggerEnter(Collider other)
    {
        if (collected || !other.CompareTag("Player"))
            return;

        PlayerControl player = other.GetComponent<PlayerControl>();

        if (player == null)
            return;

        collected = true;
        player.powerUpActive = true;

        if (specialWallRenderer != null)
        {
            specialWallRenderer.material.color = wallPowerUpColor;
        }

        player.speed *= speedMultiplier;
        player.GetComponent<Renderer>().material.color = powerUpColor;

        FindFirstObjectByType<GameManager>().ShowPowerUpActive();
        Destroy(gameObject);
    }
}