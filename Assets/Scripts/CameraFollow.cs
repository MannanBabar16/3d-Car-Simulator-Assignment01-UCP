using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public PlayerCarMovement player;
    public Vector3 offset;

    private void LateUpdate()
    {
        transform.position =player.transform.position + offset;
    }
}
