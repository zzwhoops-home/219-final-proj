using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField]
    private float maxSpeed;

    [SerializeField]
    private float rampDuration, reverseDelay;

    private float curSpeed, timeElapsed;
    private int direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // add time
        timeElapsed += Time.deltaTime;

        float angle = curSpeed * timeElapsed * Time.deltaTime;
        transform.rotation *= Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
