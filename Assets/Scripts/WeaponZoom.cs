using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedOutSensitivity = 2f;
    [SerializeField] float zoomedInSensitivity = .5f;

    bool zoomedInToggle = false;
    RigidbodyFirstPersonController fpsController;
    private void Start()
    {
        fpsController = GetComponent<RigidbodyFirstPersonController>();
    }
    private void Update()
    {
        if(zoomedInToggle)
        {
            fpsCamera.fieldOfView = zoomedInFOV;
            fpsController.mouseLook.XSensitivity = zoomedInSensitivity;
            fpsController.mouseLook.YSensitivity = zoomedInSensitivity;
        }
        else
        {
            fpsCamera.fieldOfView = zoomedOutFOV;
            fpsController.mouseLook.XSensitivity = zoomedOutSensitivity;
            fpsController.mouseLook.YSensitivity = zoomedOutSensitivity;
        }
        if(Input.GetMouseButtonDown(1))
        {
            zoomedInToggle = !zoomedInToggle;
        }
    }
}
