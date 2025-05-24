using UnityEngine;

public class TriggerLazer4 : MonoBehaviour
{
    private Animator _lazer4Animator;
    void Start()
    {
        _lazer4Animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _lazer4Animator.SetTrigger("Push 4");
        }
    }
    private void OnTriggerExit(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            _lazer4Animator.SetTrigger("Not Push 4");
        }
    }
}
