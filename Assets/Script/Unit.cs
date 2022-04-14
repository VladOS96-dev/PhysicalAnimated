using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private ConfigurableJoint joint;
    private void FixedUpdate()
    {
        Vector3 toTarget = target.position - transform.position;
        Vector3 toTargetXZ = new Vector3(toTarget.x,0,toTarget.z);
        Quaternion rotation = Quaternion.LookRotation(toTargetXZ);
        joint.targetRotation = Quaternion.Inverse(rotation);
    }
}
