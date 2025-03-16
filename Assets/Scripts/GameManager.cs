using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int nbPommes;
    public TextMeshProUGUI pommesTexte;

    public void AjouterPomme()
    {
        nbPommes++;
        pommesTexte.text = nbPommes + "/30";
    }

}
