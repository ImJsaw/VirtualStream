using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    public UnityEngine.UI.Text fpsShower;
    private float minFPS = 999;
    private float maxFPS = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float fps = 1 / Time.unscaledDeltaTime;
        if (fps > maxFPS)
            maxFPS = fps;
        if (fps < minFPS)
            minFPS = fps;

        fpsShower.text = "min" + minFPS + "\nmax" + maxFPS + "\ncur" + fps;
    }
}
