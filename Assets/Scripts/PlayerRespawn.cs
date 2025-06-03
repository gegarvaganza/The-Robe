using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 respawnPoint;
    public GameObject deathEffect;

    void Start()
    {
        // Store the initial spawn position as the default respawn point
        respawnPoint = transform.position;
    }

    // This can be called by a checkpoint to update the respawn location
    public void SetCheckpoint(Vector3 checkpointPosition)
    {
        respawnPoint = checkpointPosition;
    }

    // Respawn the player at the last checkpoint
    public void Respawn()
    {
        // Play death effect at current location if assigned
        if (deathEffect != null)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }

        // Move the player back to the respawn point
        transform.position = respawnPoint;
    }

    // Detect when player enters a DeathZone
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathZone"))
        {
            Respawn();
        }
    }
}
