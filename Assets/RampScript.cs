using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RampScript : MonoBehaviour
{
    public Text text;
    public LevelHandler lh;
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<Text>();       
        lh = GameObject.Find("GameMaster").GetComponent<LevelHandler>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateAndDisplay(float time)
    {
        text.text="Time Remaining: "+time;
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("entered");
        lh.AddTime();
        
    }
}
