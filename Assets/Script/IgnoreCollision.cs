using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    [SerializeField] private List<Collider> ignoreColliders;
    private void Awake()
    {
        for (int i = 0; i < ignoreColliders.Count; i++)
        {
            for (int j = 0; j < ignoreColliders.Count; j++)
            {
                Physics.IgnoreCollision(ignoreColliders[i],ignoreColliders[j],true);
            }
        }
    }
}
