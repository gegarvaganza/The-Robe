using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Get horizontal input (A/D or Left/Right keys)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Move the object along the X-axis
        transform.position += new Vector3(horizontalInput, 0, 0) * speed * Time.deltaTime;
    }
}
