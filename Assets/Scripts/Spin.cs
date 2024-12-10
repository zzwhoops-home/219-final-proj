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
        curSpeed = 0f;
        timeElapsed = 0f;
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // add time
        timeElapsed += Time.deltaTime;

        if (timeElapsed < rampDuration)
        {
            curSpeed = Mathf.Lerp(0f, maxSpeed, timeElapsed / rampDuration);
        }
        else if (timeElapsed <= rampDuration + reverseDelay)
        {
            curSpeed = maxSpeed;
        }
        else if (timeElapsed <= 2 * rampDuration + reverseDelay)
        {
            curSpeed = Mathf.Lerp(maxSpeed, 0f, (timeElapsed - rampDuration - reverseDelay));
        }
        else
        {
            direction *= -1;
            timeElapsed = 0f;
        }

        float angle = curSpeed * direction * Time.deltaTime;
        transform.rotation *= Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
