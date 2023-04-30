using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera leftCam;
    [SerializeField] private CinemachineVirtualCamera rightCam;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            leftCam.Priority = 2;
        } else if (Input.GetMouseButtonUp(0))
        {
            leftCam.Priority = 0;
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            rightCam.Priority = 2;
        } else if (Input.GetMouseButtonUp(1))
        {
            rightCam.Priority = 0;
        }
    }
}
