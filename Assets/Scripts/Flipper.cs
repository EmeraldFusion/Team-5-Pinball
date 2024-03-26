using ModularOptions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Flipper : MonoBehaviour
{
    private Rigidbody RgB;
    private AudioSource Sound;
    [SerializeField]
    private AudioClip BallHit;
    [SerializeField]
    private AudioClip FlipperUp4;
    public float push;
    // Start is called before the first frame update
    void Start()
    {
        RgB = GetComponent<Rigidbody>();
        Sound = GetComponent<AudioSource>();
        Assert.IsNotNull(BallHit);
        Assert.IsNotNull(FlipperUp4);
    }

    private void OnCollisionEnter(Collision collision)
    {
        var ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            Sound.PlayOneShot(BallHit);
        }
    }

    // Update is called once per frame
    public void Flip()
    {
        Sound.PlayOneShot(FlipperUp4);
        RgB.AddForce(Vector3.forward * push, ForceMode.Impulse);
    }
}
