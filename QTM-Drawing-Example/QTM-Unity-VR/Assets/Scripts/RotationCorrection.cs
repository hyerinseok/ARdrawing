using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class RotationCorrection : MonoBehaviour
{
    public GameObject QTMCamera;
    public GameObject accelCamera;
    public Camera maincam;
    public float lerpSpeed;

    private void Start()
    {
        maincam = Camera.main;
        Screen.orientation = ScreenOrientation.LandscapeRight;
    }
    // Update is called once per frame
    void Update() {
        UnityEngine.XR.XRDevice.DisableAutoXRCameraTracking(maincam, true);

        //Quaternion correction = QTMCamera.transform.rotation * Quaternion.Inverse(accelCamera.transform.localRotation);
        //transform.rotation = Quaternion.Lerp(QTMCamera.transform.rotation, correction, lerpSpeed);

        transform.position = QTMCamera.transform.position;
        transform.rotation = QTMCamera.transform.rotation;

    }
}
