using UnityEngine;

public class titleoption : MonoBehaviour
{
    public GameObject pause;
    public GameObject titlecanvas;

    public void option()
    {
        pause.SetActive(true);
        titlecanvas.SetActive(false);
    }
}
