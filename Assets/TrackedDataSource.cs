using UnityEngine;

public class TrackedDataSource : MonoBehaviour
{
    [SerializeField] public Transform movementHead = null;
    [SerializeField] public Transform charachterHead = null;

    protected void Update()
    {
        // Copy over the transform the position rotation movement data
        Utils.CopyTransform(movementHead, charachterHead);

        // When the person is moving foward a cube turns blue

        // When the person is moving backwards the cube turns red

        // Whatever else cool things you want
    }
}
