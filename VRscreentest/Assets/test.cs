using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
	public GameObject maincam;
	public Camera mc;
	
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true; //enable the gyroscope
    }

    // Update is called once per frame
	void Update () 
    {
		UnityEngine.XR.XRDevice.DisableAutoXRCameraTracking(mc, true); // disable camera movement on it's own
		if(Input.touchCount > 0)
		{
			Debug.Log("Gyroscope : " + Input.gyro.attitude.eulerAngles); //gyroscope attitudes
			Debug.Log("Accelerometer : " + -Input.acceleration.y + ", " + Input.acceleration.x); //accelerometer
			Debug.Log("maincamera : " + maincam.transform.rotation.eulerAngles); //main camera gyroscope
			//Debug.Log("maincamera : " + maincam.transform.rotation);
			//Debug.Log("maincamera : " + maincam.transform.localRotation);
		}
    }
}
