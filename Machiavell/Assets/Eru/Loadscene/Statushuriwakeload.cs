using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Statushuriwakeload : MonoBehaviour
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
        StartCoroutine(fusionLoad());
    }
    public void Leftload()
    {
        saveClass.enabled = true;
        readClass.enabled = true;
        StartCoroutine(inbentoryLoad());
    }
    private IEnumerator fusionLoad()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Weaponfusion");
        yield break;
    }
    private IEnumerator inbentoryLoad()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Inbentory");
        yield break;
    }
}
