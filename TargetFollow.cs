using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollow : MonoBehaviour
{
    public Transform target;

    public Vector3 dir;
    public float angle;
    // Update is called once per frame
    void Update()
    {
         dir = target.position - transform.position;
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation=Quaternion.AngleAxis(angle,Vector3.forward);
    }
}
