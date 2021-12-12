using UnityEngine;

public class Drive_Bridge : MonoBehaviour
{
    public WheelCollider frontLeftWC, frontRightWC;
    public WheelCollider rearLeftWC, rearRightWC;
    public Transform frontLeftT, frontRightT;
    public Transform rearLeftT, rearRightT;

    [HideInInspector]
    public float speedParameter;
    [HideInInspector]
    public float steerParameter;
    [HideInInspector]
    public float breakParameter;

    private Rigidbody rb;
    private Vector3 pos;
    private Quaternion rot;
    // Start is called before the first frame update
    void Start()
    {
        speedParameter = 0;
        steerParameter = 0;
        breakParameter = 0;
        rb = GetComponentInParent<Rigidbody>();
        rb.centerOfMass = rb.centerOfMass + new Vector3(0, -0.8f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Accelerate();
        Steer();
        ApplyBreaks();
        UpdateWheelPositions();
    }

    private void Accelerate()
    {
        rearLeftWC.motorTorque = speedParameter;
        rearRightWC.motorTorque = speedParameter;
    }

    private void Steer()
    {
        frontLeftWC.steerAngle = steerParameter;
        frontRightWC.steerAngle = steerParameter;
    }

    private void ApplyBreaks()
    {
        rearLeftWC.brakeTorque = breakParameter;
        rearRightWC.brakeTorque = breakParameter;
        frontLeftWC.brakeTorque = breakParameter;
        frontRightWC.brakeTorque = breakParameter;
    }

    private void UpdateWheelPositions()
    {
        UpdateWheelPosition(frontLeftT, frontLeftWC);
        UpdateWheelPosition(frontRightT, frontRightWC);
        UpdateWheelPosition(rearLeftT, rearLeftWC);
        UpdateWheelPosition(rearRightT, rearRightWC);
    }

    private void UpdateWheelPosition(Transform trans, WheelCollider wc)
    {
        pos = trans.position;
        rot = trans.rotation;
        wc.GetWorldPose(out pos, out rot);
        trans.position = pos;
        trans.rotation = rot * Quaternion.Euler(0,0,90);
    }
}
