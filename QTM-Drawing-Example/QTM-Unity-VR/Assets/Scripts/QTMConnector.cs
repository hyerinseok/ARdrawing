using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QTMRealTimeSDK;
using QTMRealTimeSDK.Data;
using QualisysRealTime.Unity;

public class QTMConnector : MonoBehaviour
{
    public string host;
    private DiscoveryResponse server;
    private bool foundServer = false;
    private RTClient rtClient;

    // Start is called before the first frame update
    void Start()
    {
        rtClient = RTClient.GetInstance();
    
        // Loop through discovered servers to find one that matches our needs
        foreach (var discoveryResponse in rtClient.GetServers()) {
            if (discoveryResponse.IpAddress == host) {
                Debug.Log("Desired Host Found");
                server = discoveryResponse;
                foundServer = true;
            }
        }

        // Maybe do something on update to attempt again?
        if (foundServer) {
            rtClient.Connect(server, 4545, true, true, false, false, false, false);
        }
    }
}
