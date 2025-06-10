using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioSource footstepsound;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            footstepsound.enabled = true;
        }
        else
        {
            footstepsound.enabled = false;
        }
    }
}
