using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FlipperType
{
    LEFT, 
    RIGHT, 
    BOTTOMRIGHT, 
    BOTTOMLEFT,
}




public class Flipper : MonoBehaviour
{
    public FlipperType type;


    private Rigidbody RgB;
    public float push;

    void Start()
    {
        RgB = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var input = Game.Instance.input;
        if (type == FlipperType.LEFT && input.Default.FlipL.WasPressedThisFrame())
        {
            Flip();
        }
        else if (type == FlipperType.RIGHT && input.Default.FlipR.WasPressedThisFrame())
        {
            Flip();
        }
        else if (type == FlipperType.BOTTOMRIGHT && input.Default.ExtraR.WasPressedThisFrame())
        {
            Flip();
        }
        else if (type  == FlipperType.BOTTOMLEFT && input.Default.ExtraL.WasPressedThisFrame())
        {
            Flip();
        }
    }

    public void Flip()
    {
        RgB.AddRelativeForce(Vector3.forward * push, ForceMode.Impulse);
    }
}
