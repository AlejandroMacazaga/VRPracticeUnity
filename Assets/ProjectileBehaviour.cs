using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    
    public void SetSpeed(Vector3 speed)
    {
        GetComponent<Rigidbody>().velocity = speed;
    }
    
    public void OnCollisionEnter(Collision collision) {
        Destroy(gameObject);
    }
}
