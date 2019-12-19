using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpCam : MonoBehaviour
{
    public GameObject localCamera;
    public GameObject worldCamera;
    public GameObject localCameraParent;

    public GameObject differenceCamera;

    public bool cancelLocalCameraRotation;

    public float lerpSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        if(cancelLocalCameraRotation)
            localCameraParent.transform.rotation = Quaternion.Inverse(localCamera.transform.localRotation);

        Quaternion A = worldCamera.transform.rotation * Quaternion.Inverse(localCamera.transform.localRotation);
        differenceCamera.transform.rotation = A;

        localCameraParent.transform.rotation = Quaternion.Lerp(localCameraParent.transform.rotation, A, lerpSpeed);
    }
}
