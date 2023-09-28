using UnityEngine;
using UnityEngine.SceneManagement;

public class Escapeloadscene : MonoBehaviour
{
    public Save saveClass;
    public Read readClass;

    public WeaponRead wr;
    public Kyoukareload kr;

    public void escape()
    {
        saveClass.enabled = true;
        //readClass.enabled = true;
        SceneManager.LoadScene("Temple");
    }
}
