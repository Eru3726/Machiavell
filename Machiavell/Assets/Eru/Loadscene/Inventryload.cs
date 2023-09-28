using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inventryload : MonoBehaviour
{
    public Save saveClass;
    public Read readClass;

    public WeaponRead wr;
    public Kyoukareload kr;

    void Start()
    {
        readClass.enabled = true;
        if (wr)
            wr.WeaponDelete();
        if (kr)
            kr.KyoukaDelete();
    }

    public void Rightload()
    {
        saveClass.enabled = true;
        readClass.enabled = true;
        StartCoroutine(statusLoad());
    }
    public void Leftload()
    {
        saveClass.enabled = true;
        readClass.enabled = true;
        StartCoroutine(fusionLoad());
    }
    private IEnumerator statusLoad()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Statushuriwake");
        yield break;
    }
    private IEnumerator fusionLoad()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Weaponfusion");
        yield break;
    }
}
