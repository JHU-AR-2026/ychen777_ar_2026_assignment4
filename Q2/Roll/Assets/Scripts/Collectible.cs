using UnityEngine;

public class Collectible : MonoBehaviour
{
    private bool collected;

    private void OnTriggerEnter(Collider other)
    {
        if (collected || !other.CompareTag("Player"))
            return;

        collected = true;
        FindFirstObjectByType<GameManager>().CollectCube();
        Destroy(gameObject);
    }
}