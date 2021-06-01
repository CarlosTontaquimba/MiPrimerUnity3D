using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropellerX : MonoBehaviour
{
    private float sppedPropeler = 360 * 3; //

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, sppedPropeler * Time.deltaTime);
    }
}
