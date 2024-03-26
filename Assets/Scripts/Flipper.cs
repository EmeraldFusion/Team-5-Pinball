using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    private Rigidbody RgB;
    public float push;
    // Start is called before the first frame update
    void Start()
    {
        RgB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Flip()
    {
        RgB.AddForce(Vector3.forward * push, ForceMode.Impulse);
    }
}
