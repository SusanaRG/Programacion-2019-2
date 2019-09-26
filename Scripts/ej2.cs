using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej2 : MonoBehaviour
{
    Renderer mRender;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        mRender = GetComponent<Renderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        Color R = new Color(1, 0, 0);
        Color A = new Color(0, 0, 1);
        Color M = new Color(1, 0, 1);

        if(t <= 3)
        {
            mRender.material.color = R;
        }
        if (t >= 3 && t <= 6)
        {
            mRender.material.color = A;
        }
        if (t > 6)
        {
            mRender.material.color = M;
        }
    }
}
