using ModularOptions;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // set in inspector
    public float launchForce;


    // private fields
    private Rigidbody RgB;
    private AudioSource spawnSound;
    private bool canBeLaunched;
    private bool isDoorOpen;


    void Start()
    {
        RgB = GetComponent<Rigidbody>();
        spawnSound = GetComponent<AudioSource>();
        canBeLaunched = true;
        isDoorOpen = false;
    }

    private void Update()
    {
        var input = Game.Instance.input;
        if (canBeLaunched && input.Default.LaunchB.WasReleasedThisFrame())
        {
            LaunchBall();
        }
    }

    // Deals with triggers
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BallDespawner"))
        {
            SpawnBall();
            GameObject.FindWithTag("TheWall").GetComponent<MeshRenderer>().enabled = false;
            GameObject.FindWithTag("TheWall").GetComponent<MeshCollider>().enabled = false;
            isDoorOpen = true;
        }
        // when ball passes throw the trigger, open the door
        else if (other.CompareTag("BallSpawner"))
        {
            GameObject.FindWithTag("TheWall").GetComponent<MeshRenderer>().enabled = false;
            GameObject.FindWithTag("TheWall").GetComponent<MeshCollider>().enabled = false;
            isDoorOpen = true;
        }
    }

    // When it exits a trigger, close the door
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("WallTrigger"))
        {
            GameObject.FindWithTag("TheWall").GetComponent<MeshRenderer>().enabled = true;
            GameObject.FindWithTag("TheWall").GetComponent<MeshCollider>().enabled = true;
            isDoorOpen = false;
        }
    }

    // Deals with collisions
    private void OnCollisionEnter(Collision collision)
    {
        var bumper = collision.gameObject.GetComponent<Bumper>();
        if (bumper != null)
        {
            bumper.Bump();
        }
    }
    
    // Lauches ball
    public void LaunchBall()
    {
        launchForce = Random.Range(launchForce * 0.8f, launchForce * 1.2f);
        RgB.AddForce(Vector3.forward * launchForce, ForceMode.Impulse);
        canBeLaunched = false;
    }

    // Spawns the ball in it's dedicated space and plays sound
    public void SpawnBall()
    {
        transform.position = GameObject.FindGameObjectWithTag("BallSpawner").transform.position;
        RgB.velocity = Vector3.zero;
        spawnSound.Play();
        canBeLaunched = true;
    }


}
