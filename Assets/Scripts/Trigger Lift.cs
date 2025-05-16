using UnityEngine;

public class TriggerLift : MonoBehaviour
{
    private Animator _liftAnimator;
    void Start()
    {
        _liftAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _liftAnimator.SetTrigger("Above");
        }
    }
    private void OnTriggerExit(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            _liftAnimator.SetTrigger("Ground");
        }
    }
}
