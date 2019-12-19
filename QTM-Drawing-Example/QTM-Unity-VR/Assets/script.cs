using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InputTracking.disablePositionalTracking = true;
        XRDevice.DisableAutoXRCameraTracking(Camera.main, true);
    }

    // Update is called once per frame
    void Update()
    {
        InputTracking.disablePositionalTracking = true;
        XRDevice.DisableAutoXRCameraTracking(Camera.main, true);
    }
}
