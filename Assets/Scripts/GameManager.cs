using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    private int nbPommes;
    public int nbPommesRequises;
    public GameObject gateauFinal;
    public TextMeshProUGUI pommesTexte;

    public void AjouterPomme()
    {
        nbPommes++;
        pommesTexte.text = nbPommes + "/30";
        if (nbPommes >= nbPommesRequises)
        {
            FaireApparaitreGateau();
        }
    }

    public void FaireApparaitreGateau()
    {
        if (gateauFinal != null)
        {
            Vector3 position = new Vector3(-30.89258f, 8.95f, -17.66478f);
            Instantiate(gateauFinal, position, Quaternion.identity);
        }
    }

    public void GateauFinal()
    {

    }

}
