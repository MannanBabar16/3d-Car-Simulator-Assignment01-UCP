using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverCameraMovement : MonoBehaviour
{
    public PlayerCarMovement player;
    public Vector3 driverOffset;

    private void LateUpdate()
    {
        transform.position =player.transform.position + driverOffset;
    }
}
