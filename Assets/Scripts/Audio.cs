using UnityEngine;

public class Audio : MonoBehaviour
{
    [Header("--------------- Audio Source ----------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("--------------- Audio Clip ----------------")]
    public AudioClip background;
    public AudioClip death;
    public AudioClip wallTouch;
    public AudioClip Jump;
    public AudioClip Crouch;
    public AudioClip Run;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
}
