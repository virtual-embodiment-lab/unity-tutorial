using UnityEngine;

public class TextFaceCamera : MonoBehaviour
{
    Camera cameraToLookAt;
    // Use this for initialization 
    void Start()
    {
        cameraToLookAt = Camera.main;
    }

    // Update is called once per frame 
    void LateUpdate()
    {
        transform.LookAt(cameraToLookAt.transform);
        transform.rotation = Quaternion.LookRotation(cameraToLookAt.transform.forward);
    }
}
