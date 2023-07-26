using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huwa2 : MonoBehaviour
{
    private float rand;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        rand = Mathf.PerlinNoise(Time.time-0.5f, 0);

        transform.localPosition = new Vector3(0, rand - 0.5f, 0);
    }
}
