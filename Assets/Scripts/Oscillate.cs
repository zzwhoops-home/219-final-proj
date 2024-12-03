using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillate : MonoBehaviour
{
    private float initialY;

    [SerializeField]
    private float yVariance = 3f;
    [SerializeField]
    private float speed = 2f;

    private float elapsed = 0f;

    private void Start()
    {
        initialY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        float y = (Mathf.Sin(elapsed * speed) * yVariance) + initialY;

        Vector3 newPos = new Vector3(transform.position.x, y, transform.position.z);
        transform.position = newPos;
    }
}
