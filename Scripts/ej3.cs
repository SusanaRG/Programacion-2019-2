using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3 : MonoBehaviour
{
    Light mLuz;
    // Start is called before the first frame update
    void Start()
    {
        mLuz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        Color A = new Color(0, 0, 1);
        Color R = new Color(1, 0, 0);
        Color B = new Color(1, 1, 1);

        if(mLuz.intensity >= 0.25 && mLuz.intensity < 0.5)
        {
            mLuz.color = A;
        }
        if (mLuz.intensity >= 0.5 && mLuz.intensity < 0.75)
        {
            mLuz.color = R;
        }
        if (mLuz.intensity >= 0.75)
        {
            mLuz.color = B;
        }
    }
}
