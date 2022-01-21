using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{

    public AudioClip bounceAudio;
    private AudioSource ballAudio;
    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ballAudio = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        ballAudio.PlayOneShot(bounceAudio, rigidBody.velocity.magnitude);
    }
}
