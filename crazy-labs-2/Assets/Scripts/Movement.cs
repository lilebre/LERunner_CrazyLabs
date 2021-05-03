using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Touch touch;
    private float xValue;
    [SerializeField] public float forwardsSpeed = 2f;
    [SerializeField] public float mobileSpeed = 0.1f;
    [SerializeField] public float pcTestSpeed = 5f;

    void Update()
    {
       PhoneControls();
       //PcTest();
    }

    private void PhoneControls()
    {
        transform.Translate(0, 0, forwardsSpeed * Time.deltaTime);

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
        }

        if (touch.phase == TouchPhase.Moved)
        {
            transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * mobileSpeed, transform.position.y, transform.position.z);
        }
    }
    
    //private void PcTest()
    //{
    //
    //    float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
    //    transform.Translate(xValue * pcTestSpeed, 0, forwardsSpeed * Time.deltaTime);
    //}




}
