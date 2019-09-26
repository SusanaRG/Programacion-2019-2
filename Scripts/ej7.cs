using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej7 : MonoBehaviour
{
    Light mluz;
    private float T = 0;
    private float T1 = 0;
    float m = 0.2f;
    float b = 0f;
    float m1 = 0.33f;
    float b1 = 1f;
    // Start is called before the first frame update
    void Start()
    {
        mluz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        T += Time.deltaTime;
        float Y = m * T + b;
        float Y1 = -m1 * T + b1;
        if (T <= 5)
        {
            mluz.color = new Color(Y, 0, 0);
        }
        if (T > 5)
        {
            T1 += Time.deltaTime;
            if (T1 <= 3)
            {
                mluz.color = new Color(Y1, 0, 0);
            }

        }
    }
}
