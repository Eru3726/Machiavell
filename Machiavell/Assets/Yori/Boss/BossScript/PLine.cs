using System.Collections;
using UnityEngine;

public class PLine : MonoBehaviour
{
    private Vector2 pos;
    SpriteRenderer sr;
    GameObject target;
    public bool flgFade = true;
    private bool flgLine = true;
    private bool nextLineFlg = false;
    private int count = 0;
    private Vector3 line;

    private BOSS_AI boss;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        target = GameObject.Find("player");

        GameObject obj = GameObject.Find("Archange");
        boss = obj.GetComponent<BOSS_AI>();
        line = this.gameObject.transform.localScale;
        line.y = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (count >= 3)
        {
            boss.tackleFlg = true;

            line = this.gameObject.transform.localScale;
            line.y -= 0.2f;
            this.gameObject.transform.localScale = line;
            if (line.y < 0)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            line = this.gameObject.transform.localScale;
            if (flgLine)
            {
                StartCoroutine(lineOp());
                flgLine = false;
            }

            pos = this.gameObject.transform.position;
            pos.y = target.transform.position.y;
            pos.x = 0;
            this.gameObject.transform.position = pos;
        }
        if (nextLineFlg)
        {
            if (flgFade)
            {
                //color.a += 0.1f;
                gameObject.GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, 0.02f);

                //ˆÃ‚­‚È‚Á‚½
                if (sr.color.a >= 0.4)
                {
                    flgFade = false;
                }
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, 0.02f);
                if (sr.color.a <= 0.1)
                {
                    flgFade = true;
                    count++;
                }
            }
        }        
    }
    IEnumerator lineOp()
    {
        while (line.y <= 7)
        {
            line.y += 0.2f;
            this.gameObject.transform.localScale = line;
            yield return new WaitForSeconds(0.01f);
        }
        nextLineFlg = true;
        yield break;
    }
}
