using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weaponfusionload : MonoBehaviour
{
    public Save saveClass;
    public Read readClass;

    public WeaponRead wr;
    public Kyoukareload kr;
    // Start is called before the first frame update
    void Start()
    {
        readClass.enabled = true;
        if (wr)
            wr.WeaponDelete();
        if (kr)
            kr.KyoukaDelete();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Rightload()
    {
        saveClass.enabled = true;
        readClass.enabled = true;
        StartCoroutine(inbentoryLoad());
    }
    public void Leftload()
    {
        saveClass.enabled = true;
        readClass.enabled = true;
        StartCoroutine(statusLoad());
    }
    private IEnumerator statusLoad()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Statushuriwake");
        yield break;
    }
    private IEnumerator inbentoryLoad()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Inbentory");
        yield break;
    }
}
