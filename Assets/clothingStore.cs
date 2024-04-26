using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


public class clothingStore : MonoBehaviour
{

    public Text lePrix;
    public Text laReduc;

    private int prix;
    private int reduc;

    private float nvPrix;
    private string leNvPrix;

    public TMPro.TextMeshProUGUI prixJoueur;
    public Button submit;

    public string scenePerdu;
    public string sceneGagne;


    void Awake()
    {
        System.Random rnd = new System.Random();

        prix= rnd.Next(1, 100);
        reduc = rnd.Next(1, 100);

        lePrix.text = prix.ToString()+ " €";
        laReduc.text = "- "+reduc.ToString()+" %";

    }

    void Start() 
    {

        submit.onClick.AddListener(OnClick);

        nvPrix = solde();
        int nvPrixInt = (int)Math.Round(nvPrix);
    }

    float solde() {

        float price= prix *(100 - reduc) / 100;

        return price;

    }

    void OnClick()
    {

        bool ok = (prixJoueur.text == leNvPrix);

        if (prixJoueur.text == nvPrix.ToString())
        {
            print("gagné");
            
        }
        else
        {
            print("perdu");
            print(prixJoueur.text);
            print(leNvPrix);
            print(prixJoueur.text != leNvPrix);
            SceneManager.LoadScene(scenePerdu);
        }
        SceneManager.LoadScene(sceneGagne);
    }

}
