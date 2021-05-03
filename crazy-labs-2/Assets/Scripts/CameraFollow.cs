using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject playerReference;
    Transform playerTransform;
    [SerializeField] public Vector3 offset;
    

    void Start()
    {
        playerTransform = playerReference.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 0, playerTransform.position.z) + offset;
    }
}
