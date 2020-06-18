using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject playerObject;

    float x_offset = 0;
    private void Start()
    {
        x_offset = playerObject.transform.position.x - mainCamera.transform.position.x;
    }
    void Update()
    {
        if(playerObject.transform.position.x - mainCamera.transform.position.x < x_offset)
        {
            mainCamera.transform.position = new Vector3(playerObject.transform.position.x-x_offset, mainCamera.transform.position.y, mainCamera.transform.position.z);
        }
        
    }
}
