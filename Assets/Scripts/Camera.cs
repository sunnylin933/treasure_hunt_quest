using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform trackingTarget;

    public float followSpeed = 0;
    public float xOffset;
    public float yOffset;

    private bool tracking = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xTarget = trackingTarget.position.x;
        float yTarget = trackingTarget.position.y;

        if(xTarget > 8 || yTarget > 2)
        {
            tracking = true;
        }

        if(tracking)
        {
            float xUpdate = Mathf.Lerp(transform.position.x, xTarget, Time.deltaTime * followSpeed);
            float yUpdate = Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * followSpeed);
            transform.position = new Vector3(xUpdate, yUpdate, transform.position.z);
        }


    }
}
