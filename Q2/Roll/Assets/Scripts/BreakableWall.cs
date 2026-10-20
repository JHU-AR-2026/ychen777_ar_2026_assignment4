using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        TryBreak(collision);
    }

    private void OnCollisionStay(Collision collision)
    {
        TryBreak(collision);
    }

    private void TryBreak(Collision collision)
    {
        PlayerControl player =
            collision.gameObject.GetComponent<PlayerControl>();

        if (player != null && player.powerUpActive)
        {
            Destroy(gameObject);
        }
    }
}