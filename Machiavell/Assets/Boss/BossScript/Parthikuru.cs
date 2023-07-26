using System.Collections;
using UnityEngine;

public class Parthikuru : MonoBehaviour
{
    private GameObject obj;
    public BOSS_AI boss;

    [SerializeField, Header("最初のパーティクル")]
    private GameObject teleStart;

    [SerializeField, Header("最後のパーティクル")]
    private GameObject teleEnd;

    [SerializeField, Header("テレポートから出るパーティクル")]
    private GameObject warpEnd;

    public bool tp = true;
    void Start()
    {
        obj = GameObject.Find("Archange");
    }

    void Update()
    {
        if (boss.tpStart)
        {
            if (tp)
            {
                StartCoroutine(startParthikle());
                tp = false;
            }
        }
        if (boss.tpEnd)
        {
            if (tp)
            {
                Debug.Log("warpend");
                StartCoroutine(endParthikle());
                tp = false;
            }
        }
    }

    IEnumerator startParthikle()
    {
        Instantiate(teleStart, new Vector2(obj.transform.position.x, obj.transform.position.y), Quaternion.identity);
        yield return new WaitForSeconds(0.8f);
        Instantiate(teleEnd, new Vector2(obj.transform.position.x, obj.transform.position.y), Quaternion.identity);
        yield return new WaitForSeconds(0.8f);
        yield break;
    }
    IEnumerator endParthikle()
    {
        Instantiate(warpEnd, new Vector2(obj.transform.position.x, obj.transform.position.y), Quaternion.identity);
        yield break;
    }
}
