using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huwa : MonoBehaviour
{
    float rand = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //rand += Time.deltaTime;
        //float y = Mathf.PerlinNoise(rand, 0);

        rand = Mathf.PerlinNoise(Time.time, 0);

        transform.localPosition = new Vector3(0, rand-0.5f, 0) ;

    }
}
