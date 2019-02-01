using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ChairCalibrate : MonoBehaviour
{

    [SteamVR_DefaultAction("ChairCenter")]

    public GameObject LeftController;
    public List<GameObject> busList = new List<GameObject>();
    public GameObject seatBus, calibrationBus;
    private Vector3 pos, calibrationSeat;
    private float yRotation;

    // Update is called once per frame
    void Update()
    {
        //if the pinch button on the left controller is pressed
        if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            //get the y rotation of the left controller
            yRotation = LeftController.transform.eulerAngles.y;

            //rotate skybox
            RenderSettings.skybox.SetFloat("_Rotation", yRotation * -1 + 300);

            //rotate the calibration bus (which is the first bus active)
            calibrationBus.transform.eulerAngles = new Vector3(0, yRotation, 0);

            //controller and seat's position
            pos = LeftController.transform.position;
            calibrationSeat = seatBus.transform.localPosition;

            //seat position after rotation
            calibrationSeat = calibrationBus.transform.rotation * calibrationSeat;

            //set final position to the bus so the seat is at the controller's position
            calibrationBus.transform.localPosition = pos - calibrationSeat;
        }
        //every bus in the list get the same position as the calibration bus (which is the first bus active)
        foreach (var bus in busList)
        {
            if (bus.activeSelf == true)
            {
                //set rotation and position to the activated bus
                bus.transform.eulerAngles = new Vector3(0, yRotation, 0);
                bus.transform.localPosition = pos - calibrationSeat;
            }
        }
    }
}
