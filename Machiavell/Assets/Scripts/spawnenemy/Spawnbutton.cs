using UnityEngine;

public class Spawnbutton : MonoBehaviour
{ 
    public GameObject create;
    Createenemy createenemy;
    private float rnd;
    public GameObject slime, zombie, bad;
    void Start()
    {
        createenemy = create.GetComponent<Createenemy>();
        rnd = 1;
    }

    
    void Update()
    {
    }

    public void OnClick()
    {
            if (rnd == 1)
            {
                createenemy.enemynumber = 1;
                create.GetComponent<Createenemy>().Instansenemy();
                rnd += 1;
                
            }
            else if (rnd == 2)
            {
                createenemy.enemynumber = 2;
                create.GetComponent<Createenemy>().Instansenemy();   
                rnd += 1;
                
            }
            else if (rnd == 3)
            {    
                createenemy.enemynumber = 3;
                create.GetComponent<Createenemy>().Instansenemy();
                rnd = 1;
            }
    }
}
