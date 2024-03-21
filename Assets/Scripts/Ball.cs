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

    // Update is called once per frame
    public void Launch()
    {
        RgB.AddForce(Vector3.forward * launchForce, ForceMode.Impulse);
    }
}
