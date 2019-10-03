using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motor : MonoBehaviour
{

    [SerializeField] float mag = 8;
    [SerializeField] float magAng = 90;
    AudioSource aud;
    Rigidbody mCuerpo;
    float T = 0f;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
        mCuerpo = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float MagFuerzaV = 10f;
        float SenV = 1;
        Vector3 dirV = transform.up;
        Vector3 FuerzaV = MagFuerzaV * dirV * SenV;

        float MagFuerzaH = 100f;
        float SenH = 1;
        Vector3 dirH = transform.forward;
        Vector3 FuerzaH = MagFuerzaH * dirH * SenH;

        if(Input.GetButtonDown("Jump") && mCuerpo.position.y < 1)
        {
            mCuerpo.AddForce(FuerzaH);
            mCuerpo.AddForce(FuerzaV);
            T += Time.deltaTime;
        }

        if(T > 1 && T < 1.5)
        {
            mCuerpo.velocity = Vector3.zero;
            T = 0f;
        }
        //movimiento y rotacion 
        Vector3 dir = transform.forward * Input.GetAxis("Vertical");
        Vector3 vel = mag * dir;
        Vector3 dist = vel * Time.deltaTime;
        transform.position += dist;

        Vector3 dirAng = new Vector3(0, 1, 0) * Input.GetAxis("Horizontal");
        Vector3 velAng = magAng * dirAng;
        Vector3 distAng = velAng * Time.deltaTime;
        transform.eulerAngles += distAng;

        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            aud.mute = false;

        }
        else
        {
            aud.mute = true;
        }

        


    }
}
