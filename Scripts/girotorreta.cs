using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girotorreta : MonoBehaviour
{
    [SerializeField] float magAng = 90;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dirAng = new Vector3(0, 1, 0) * Input.GetAxis("HorizontalTorreta");
        Vector3 velAng = magAng * dirAng;
        Vector3 distAng = velAng * Time.deltaTime;
        transform.eulerAngles += distAng;
    }
}
