using UnityEngine;

public class TriggerLazer3 : MonoBehaviour
{
    private Animator _lazer3Animator;
    void Start()
    {
        _lazer3Animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _lazer3Animator.SetTrigger("Push 3");
        }
    }
    private void OnTriggerExit(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            _lazer3Animator.SetTrigger("Not Push 3");
        }
    }
}
