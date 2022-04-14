using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(ConfigurableJoint))]
public class PhysicalBodyPart : MonoBehaviour
{
    [SerializeField] private Transform target;
    private ConfigurableJoint joint;
    private Quaternion startRotation;
    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();
        startRotation = transform.localRotation;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        joint.targetRotation = Quaternion.Inverse(target.localRotation) * startRotation;
    }
    
}
