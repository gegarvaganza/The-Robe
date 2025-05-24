using UnityEngine;

public class TriggerLazer2 : MonoBehaviour
{
    private Animator _lazer2Animator;
    void Start()
    {
        _lazer2Animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _lazer2Animator.SetTrigger("Push 2");
        }
    }
    private void OnTriggerExit(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            _lazer2Animator.SetTrigger("Not Push 2");
        }
    }
}
