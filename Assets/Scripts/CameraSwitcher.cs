using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera thirdPersonCamera; 
    public Camera driverViewCamera; 

    private bool isDriverView = false; 

    private void Start()
    {
 
        if (thirdPersonCamera != null)
        {
            thirdPersonCamera.enabled = !isDriverView;
        }

        if (driverViewCamera != null)
        {
            driverViewCamera.enabled = isDriverView;
        }
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.V))
        {
            SwitchCameraView();
        }
    }

    private void SwitchCameraView()
    {
    
        isDriverView = !isDriverView;


        if (thirdPersonCamera != null)
        {
            thirdPersonCamera.enabled = !isDriverView;
        }

        if (driverViewCamera != null)
        {
            driverViewCamera.enabled = isDriverView;
        }
    }
}
