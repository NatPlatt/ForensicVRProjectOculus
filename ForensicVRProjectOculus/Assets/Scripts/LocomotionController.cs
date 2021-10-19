using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{
    public XRController leftTeleportRay;
    public XRController rightTeleportRay;
    public InputHelpers.Button leftteleportActivateButton;
    public InputHelpers.Button rightteleportActivateButton;
    public float activationThreshold;

    public bool EnableLeftTeleport { get; set; } = true;
    public bool EnableRightTeleport { get; set; } = true;
    
    void Update()
    {
        if (leftTeleportRay)
        {
            leftTeleportRay.gameObject.SetActive(EnableLeftTeleport && CheckIfLeftActivated(leftTeleportRay));
        }
        if (rightTeleportRay)
        {
            rightTeleportRay.gameObject.SetActive(EnableRightTeleport && CheckIfRightActivated(rightTeleportRay));
        }
    }

    public bool CheckIfLeftActivated(XRController controller)
    {
        //InputHelpers.IsPressed(controller.inputDevice, teleportActivateButton, out bool isActivated);
        InputHelpers.IsPressed(controller.inputDevice, leftteleportActivateButton, out bool leftIsActivated,
            activationThreshold);
        return leftIsActivated;
    }
    
    public bool CheckIfRightActivated(XRController controller)
    {
        //InputHelpers.IsPressed(controller.inputDevice, teleportActivateButton, out bool isActivated);
        InputHelpers.IsPressed(controller.inputDevice, rightteleportActivateButton, out bool rightIsActivated,
            activationThreshold);
        return rightIsActivated;
    }
}
