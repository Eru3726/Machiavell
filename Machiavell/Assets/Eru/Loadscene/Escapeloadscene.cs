using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escapeloadscene : MonoBehaviour
{
    public Save saveClass;
    public Read readClass;

    public WeaponRead wr;
    public Kyoukareload kr;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void escape()
    {
        saveClass.enabled = true;
        //readClass.enabled = true;
        SceneManager.LoadScene("Temple");
    }
}
