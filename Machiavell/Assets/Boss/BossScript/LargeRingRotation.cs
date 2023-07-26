using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeRingRotation : MonoBehaviour
{
    private float sRotation = 1.5f;

    private float readyBeam = 10f;

    private float endBeam = 1.5f;

    private float plusBeam = 5f;



    private BOSS_AI boss;


    void Start()
    {
        GameObject obj = GameObject.Find("Archange");
        boss = obj.GetComponent<BOSS_AI>();
    }

    // Update is called once per frame
    void Update()
    {

        if (boss.beamReady)
        {
            StartCoroutine(sRotate());
            boss.beamReady = false;
        }

        if(boss.beamEnd)
        {
            StartCoroutine(eRotate());
            boss.beamEnd = false;
        }

        transform.Rotate(new Vector3(0, 0, sRotation));

    }

    IEnumerator sRotate()
    {
        while (sRotation < readyBeam)
        {
            sRotation += plusBeam;

            yield return new WaitForSeconds(1.5f);
        }
        yield break;
    }

    IEnumerator eRotate()
    {
        while (sRotation > endBeam)
        {
            sRotation -= plusBeam;

            yield return new WaitForSeconds(1.5f);
        }
    }
}
