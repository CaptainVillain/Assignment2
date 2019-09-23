using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayScore : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<Text>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateAndDisplay(int point)
    {
        text.text="Score: "+point;
    }
}
