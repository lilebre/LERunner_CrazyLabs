using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] public float xRotation;
    [SerializeField] public float yRotation;
    [SerializeField] public float zRotation;

    void Update()
    {
        transform.Rotate(xRotation, yRotation, zRotation);
    }
}
