using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class cakeGame : MonoBehaviour
{
    public Text part1;
    public Text part2;
    public Text part3;
    public Text part4;

    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;

    private float fraction1;
    private float fraction2;
    private float fraction3;
    private float fraction4;

    private int numerateur;
    private int denominateur;


    private float plusGrand;

    void Awake() { 

        System.Random rnd = new System.Random();

        //PART DE GATEAU 1
        numerateur = rnd.Next(1, 100);
        denominateur= rnd.Next(1, 100);

        fraction1 = numerateur / denominateur;

        part1.text = numerateur.ToString()+"/"+denominateur.ToString();

        //PART DE GATEAU 2
        numerateur = rnd.Next(1, 100);
        denominateur = rnd.Next(1, 100);

        fraction2 = numerateur / denominateur;

        part2.text = numerateur.ToString() + "/" + denominateur.ToString();

        //PART DE GATEAU 3
        numerateur = rnd.Next(1, 100);
        denominateur = rnd.Next(1, 100);

        fraction3 = numerateur / denominateur;

        part3.text = numerateur.ToString() + "/" + denominateur.ToString();

        //PART DE GATEAU 4
        numerateur = rnd.Next(1, 100);
        denominateur = rnd.Next(1, 100);

        fraction4 = numerateur / denominateur;

        part4.text = numerateur.ToString() + "/" + denominateur.ToString();

    }

    void Start() 
    {
        btn1.onClick.AddListener(TaskOnClick1);
        btn2.onClick.AddListener(TaskOnClick2);
        btn3.onClick.AddListener(TaskOnClick3);
        btn4.onClick.AddListener(TaskOnClick4);

        plusGrand=gagnant(fraction1, fraction2, fraction3,fraction4);
    }

    float gagnant(float fr1, float fr2, float fr3, float fr4) {

        float gagnant = fr1;
        if (fr2 >= gagnant) 
        { 
            gagnant = fr2;
            if (fr3 >= gagnant) 
            { 
                gagnant= fr3;
                if (fr4 >= gagnant) 
                {
                    gagnant = fr4;
                }
            }
        }

        return gagnant;
    }

    void TaskOnClick1() 
    {

            if (plusGrand == fraction1) { 
                print("gagné"); 
            } 
            else { print("perdu"); }
        

    }

    void TaskOnClick2()
    {
            if (plusGrand == fraction2) { print("gagné"); }
            else { print("perdu"); }
        

    }

    void TaskOnClick3()
    {

        
            if (plusGrand == fraction3) { print("gagné"); }
            else { print("perdu"); }
       

    }

    void TaskOnClick4()
    {

       
            if (plusGrand == fraction4) { print("gagné"); }
            else { print("perdu"); }
        

    }

    

}


