using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int vieMax;
    public int vieActuelle;

    // Start is called before the first frame update
    void Start()
    {
        vieActuelle = vieMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DegatJoueur(int degat)
    {
        vieActuelle -= degat;
    }

    public void SoignerJoueur(int soin)
    {
        vieActuelle += soin;

        if(vieActuelle > vieMax)
        {
            vieActuelle = vieMax;
        }
    }
}
