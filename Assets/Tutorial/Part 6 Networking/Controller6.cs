#if NORMCORE

using System.Collections;
using System.Collections.Generic;
using Normal.Realtime;
using UnityEngine;

public class Controller6 : MonoBehaviour
{
    //Rigidbody rb;
    public float speed = 5f;
    public float jumpAmount = 15f;
    public float gravityScale = 10f;
    public Rigidbody rb = null;

    private RealtimeView _realtimeView;
    private RealtimeTransform _realtimeTransform;

    private void Awake()
    {
        _realtimeView = GetComponent<RealtimeView>();
        _realtimeTransform = GetComponent<RealtimeTransform>();
    }

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        //rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // If this CubePlayer prefab is not owned by this client, bail.
        if (!_realtimeView.isOwnedLocallySelf)
            return;

        // Make sure we own the transform so that RealtimeTransform knows to use this client's transform to synchronize remote clients.
        _realtimeTransform.RequestOwnership();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        // If this CubePlayer prefab is not owned by this client, bail.
        if (!_realtimeView.isOwnedLocallySelf)
            return;

        rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);
        //Store user input as a movement vector
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        rb.MovePosition(transform.position + m_Input * Time.deltaTime * speed);
    }
}

#endif
