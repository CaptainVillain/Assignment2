using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHandler : MonoBehaviour
{
    float time = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
        time -= Time.deltaTime;
         if(time < 0)
         {
            SceneManager.LoadScene(0);
         }
        
    }

    public void AddTime()
    {
        time += 10f;
    }


}
