using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    Rigidbody projectile;
    public GameObject projectilePrefab;
    private Vector3 origin;
    public float offsetY;
    public float offsetZ;

    void Awake()
    {
        projectile = projectilePrefab.GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        origin = new Vector3(transform.position.x,transform.position.y+offsetY,transform.position.z+offsetZ);
        // Ctrl was pressed, launch a projectile
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            clone = Instantiate(projectile, origin, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
}
