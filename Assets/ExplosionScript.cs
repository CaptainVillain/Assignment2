using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Dismantle",1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Dismantle()
    {
        Destroy(gameObject);
    }
}
