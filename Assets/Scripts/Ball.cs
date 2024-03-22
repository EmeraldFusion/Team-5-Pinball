using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody RgB;
    public float launchForce;
    // Start is called before the first frame update
    void Start()
    {
        RgB = GetComponent<Rigidbody>();
    }

    public void Restart()
    {
        transform.position = GameObject.FindGameObjectWithTag("BallSpawner").transform.position;
        RgB.velocity = Vector3.zero;
    }

    // Update is called once per frame
    public void Launch()
    {
        RgB.AddForce(Vector3.forward * launchForce, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BallDespawner"))
        {
            transform.position = GameObject.FindGameObjectWithTag("BallSpawner").transform.position;
            RgB.velocity = Vector3.zero;
        }
    }


}
