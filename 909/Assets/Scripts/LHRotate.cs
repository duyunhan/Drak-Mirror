using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LHRotate : MonoBehaviour
{
    [SerializeField] GameObject LHObject;
    [SerializeField] float Speed = 0.1f;

    void Update()
    {
        LHObject.transform.Rotate(0, Speed, 0, Space.World);
    }
}
