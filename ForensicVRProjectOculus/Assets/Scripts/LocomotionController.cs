using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{
    public XRController leftTeleportRayInteractor;
    public XRController rightTeleportRayInteractor;
    public InputHelpers.Button teleportActivateButton;
    public float activationThreshold;

    public bool EnableLeftTeleport { get; set; } = true;
    public bool EnableRightTeleport { get; set; } = true;
    void Update()
    {
        if (leftTeleportRayInteractor)
        {
            leftTeleportRayInteractor.gameObject.SetActive(EnableLeftTeleport && CheckIfActivated(leftTeleportRayInteractor));
        }
        if (rightTeleportRayInteractor)
        {
            rightTeleportRayInteractor.gameObject.SetActive(EnableRightTeleport && CheckIfActivated(rightTeleportRayInteractor));
        }
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivateButton, out bool isActivated,
            activationThreshold);
        return isActivated;
    }
}
