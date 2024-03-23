using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{

    //private fields
    private AudioSource bumpSound;

    private void Start()
    {
        bumpSound = GetComponent<AudioSource>();
    }

    public void Bump()
    {
        bumpSound.Play();
    }
}
