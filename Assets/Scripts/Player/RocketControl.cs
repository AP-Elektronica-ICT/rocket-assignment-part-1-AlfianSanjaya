using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class RocketControl : MonoBehaviour
{
    [SerializeField] float thrusterForce = 1000f;
    [SerializeField] float tiltAngle = 100f;

    private bool power = false;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
        power = Input.GetKey(KeyCode.Space);

        RocketAudio();

        if (!Mathf.Approximately(tiltAroundZ, 0f) || !Mathf.Approximately(tiltAroundX, 0f))
        {
            rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(tiltAroundX * Time.deltaTime, 0f, -tiltAroundZ * Time.deltaTime));
        }
        rb.freezeRotation = false;
    }

    private void FixedUpdate()
    {
        if (power)
        {
            rb.AddRelativeForce(Vector3.up * thrusterForce * Time.deltaTime);
        }
    }

    private void RocketAudio()
    {
        if (power && AudioManager.Instance.IsPlaying("RocketThrust") == false)
        {
            Debug.Log("Play sound");
            AudioManager.Instance.Play("RocketThrust");
        }
        else if (power == false && AudioManager.Instance.IsPlaying("RocketThrust"))
        {
            Debug.Log("Stop sound");
            AudioManager.Instance.Stop("RocketThrust");
        }
    }
}
