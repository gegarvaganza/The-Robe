using UnityEngine;

public class TriggerLazer : MonoBehaviour
{
    private Animator _lazerAnimator;
    void Start()
    {
        _lazerAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _lazerAnimator.SetTrigger("Push");
        }
    }
    private void OnTriggerExit(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            _lazerAnimator.SetTrigger("Not Push");
        }
    }
}
