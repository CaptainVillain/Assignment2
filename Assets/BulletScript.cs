using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("BulletLogic",2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BulletLogic()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit!");
        if(collision.gameObject.tag=="Enemy")
        {
            Instantiate(explosionPrefab,transform.position,Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
    }
}
