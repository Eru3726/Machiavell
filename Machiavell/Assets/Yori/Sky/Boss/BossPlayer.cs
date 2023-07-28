using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossPlayer : MonoBehaviour
{
    public  bool Bossroom;
    float time = 0;
    [SerializeField,Header("“®‚¯‚È‚¢ŽžŠÔ")]
    private int waitTime = 4;
    public Pause pause;
    void Start()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().name=="KutyuBoss")
        {
            Bossroom = false;
            pause.PauseFlag = false;
        }
        else
        {
            Bossroom = true; ;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "KutyuBoss")
        {
            return;
        }
        if (waitTime>=time)
        {
            time += Time.deltaTime;
            if (time >= waitTime)
            {
                Bossroom = true;
                pause.PauseFlag = true;
            }
        }
        
    }
}
