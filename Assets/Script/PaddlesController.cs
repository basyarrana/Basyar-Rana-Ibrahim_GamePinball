using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PaddlesController : MonoBehaviour
{
    public KeyCode input;
    private float targetpressed;
    private float targetreleased;

    private HingeJoint hinge;
    private void Start()
    {
        hinge = GetComponent<HingeJoint>();

        targetpressed = hinge.limits.max;
        targetreleased = hinge.limits.min;
    }

    private void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
            JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.targetPosition = targetpressed;
        }
        else 
        {
            
            jointSpring.targetPosition = targetreleased;
        }

        hinge.spring = jointSpring;
    }

}
