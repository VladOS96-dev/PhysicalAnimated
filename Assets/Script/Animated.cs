using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animated : MonoBehaviour
{
    [SerializeField] private PhysicMaterial defaultMaterial;
    [SerializeField] private PhysicMaterial zeroMaterial;
    [SerializeField] private Collider leftLeg;
    [SerializeField] private Collider rightLeg;
    public void SetLeftFriction()
    {
        leftLeg.material = zeroMaterial;
        rightLeg.material = defaultMaterial;
    }

    public void SetRightFriction()
    {
        leftLeg.material = defaultMaterial;
        rightLeg.material = zeroMaterial;
    }
}
