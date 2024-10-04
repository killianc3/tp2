using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public Camera[] cameras;  // Array to hold references to all the cameras
    private int currentCameraIndex = 0;

    void Start()
    {
        // Disable all cameras except the first one
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == currentCameraIndex);
        }
    }

    void Update()
    {
        // Switch camera when the user presses the "C" key
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        // Disable current camera
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // Increment camera index and loop back if necessary
        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

        // Enable the new camera
        cameras[currentCameraIndex].gameObject.SetActive(true);
    }

}
