using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePaint : MonoBehaviour
{
    private GameObject line;
    public GameObject linePrefab;
    private bool isDrawing = false;
    public float minDistance = 0.01f;

    // Update is called once per frame
    void Update()
    {
        // Check if button is down
        if (Input.GetButtonDown("Fire1")) {
            isDrawing = true;
            line = Instantiate(linePrefab);
        }

        // Check if button is up
        if (Input.GetButtonUp("Fire1")) {
            isDrawing = false;
        }

        if (isDrawing) {
            LineRenderer currStroke = line.GetComponent<LineRenderer>();
            Vector3 lastPoint = currStroke.GetPosition(currStroke.positionCount - 1);
            Vector3 distanceVec = transform.position - lastPoint;

            // add point only if enough distance
            if (currStroke.positionCount == 0 || distanceVec.sqrMagnitude > minDistance * minDistance) {
                currStroke.positionCount += 1;
                currStroke.SetPosition(currStroke.positionCount - 1, transform.position);
            }
        }
    }
}
