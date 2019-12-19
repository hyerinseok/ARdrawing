using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QTMRealTimeSDK;
using QualisysRealTime.Unity;

// This class is very similar to QTM's RT Object,
// but I might need to make changes so I'm keeping it for now
public class QTMObject : MonoBehaviour
{
    public string objectName;
    private float updateTimer = 0f;

    private RTClient rtClient;
    // Start is called before the first frame update
    void Start() {
        rtClient = RTClient.GetInstance();
    }

    // Update is called once per frame
    void Update() {
        if (updateTimer > 0) updateTimer -= Time.deltaTime;

        if (rtClient.GetStreamingStatus()) {
            SixDOFBody trackedObj = rtClient.GetBody(objectName);

            if (!float.IsNaN(trackedObj.Position.sqrMagnitude)) {
                transform.position = trackedObj.Position;
                transform.rotation = trackedObj.Rotation;
            }
        }
    }
}
