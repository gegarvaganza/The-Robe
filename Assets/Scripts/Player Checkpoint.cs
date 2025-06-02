using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    public GameObject door;
    Vector3 spawnPoint;
    void Start()
    {
        spawnPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -20f)
        {
            gameObject.transform.position = spawnPoint;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            spawnPoint = door.transform.position;
            Destroy(door);
        }
    }
}
