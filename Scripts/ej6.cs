using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej6 : MonoBehaviour
{
    Light mLuz;
    private float t = 0;
    private float m = 0.1f;
    private float b = 1f;
    // Start is called before the first frame update
    void Start()
    {
        mLuz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        float y = -m * t + b;
        if(t <= 10)
        {
            mLuz.intensity = y;
        }
    }
}
