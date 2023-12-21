using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Vector3 cameraInitialPosition;
    private Quaternion cameraInitialRotation;
    public GameObject mainCamera;
    public GameObject snakeHead;

    enum CameraPosition { Close, Middle, Far };
    CameraPosition currentCameraPosition;

    void Start()
    {
        InitializeCameraDetails();
    }

    void InitializeCameraDetails()
    {
        currentCameraPosition = CameraPosition.Close;

        cameraInitialPosition = mainCamera.transform.localPosition;
        cameraInitialRotation = mainCamera.transform.localRotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ChangeCamera();
        }
    }

    void ChangeCamera()
    {
        if (currentCameraPosition == CameraPosition.Close)
        {
            SwitchToMiddlePosition();
        }
        else if (currentCameraPosition == CameraPosition.Middle)
        {
            SwitchToFarPosition();
        }
        else if (currentCameraPosition == CameraPosition.Far)
        {
            SwitchToClosePosition();
        }
    }

    void SwitchToMiddlePosition()
    {
        currentCameraPosition = CameraPosition.Middle;

        Transform newTransform = snakeHead.transform;
        mainCamera.transform.rotation = newTransform.rotation;
        mainCamera.transform.position = newTransform.position;
    }

    void SwitchToFarPosition()
    {
        currentCameraPosition = CameraPosition.Far;

        mainCamera.transform.localRotation = cameraInitialRotation;
        mainCamera.transform.localPosition = cameraInitialPosition + new Vector3(0f, 2f, -3f);
    }

    void SwitchToClosePosition()
    {
        currentCameraPosition = CameraPosition.Close;

        mainCamera.transform.localRotation = cameraInitialRotation;
        mainCamera.transform.localPosition = cameraInitialPosition;
    }
}
