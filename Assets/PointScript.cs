using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    private AudioSource audioSource;
    public ScoreScript ss;
    private bool hasPoint = false;
    Vector3 pointB;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GameObject.Find("Audio Source").GetComponent<AudioSource>();
        ss = GameObject.Find("GameMaster").GetComponent<ScoreScript>();
        StartMoving();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!hasPoint)
        {
            hasPoint = true;
            Debug.Log("entered");
            audioSource.Play();
            ss.AddPoint();
            Destroy(gameObject);
        }
        
    }

    
 
    private void StartMoving() {
        var pointA = transform.position;
        while (true) {
            MoveObject(transform, pointA, pointB, 3);
            MoveObject(transform, pointB, pointA, 3);
        }
    }
 
    private void MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time) {
        var i = 0.0;
        var rate = 1.0/time;
        while (i < 1.0) {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, (float)i); 
        }
    }  
}
