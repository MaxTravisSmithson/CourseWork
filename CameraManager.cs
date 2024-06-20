using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Transform target;

    private Vector3 offset;

    //Awake means that this is called when the script is being loaded
    //This makes the offset equal to what the difference is in the player position and the camera position when it starts
    //This makes it easy to edit in Unity
    private void Awake()
    {
        offset = transform.position - target.position;
    }

    //This finds the player at the target.position and makes that the cameras location
    //It then adds the offset to keep the camera away from the player
    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
