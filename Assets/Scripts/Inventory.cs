using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int coinsCount=0;
    public static Inventory instance;
    public Text porteMonnaie;
    

    private void Awake()
    {
        porteMonnaie.text = "0";
        coinsCount = 0;
        if (instance != null) 
        {
            Debug.LogWarning("Il y a plus d'une instance de Inventory dans la scène");
            return;
        }
        instance = this;
        
    }

    public void addCoins(int count) 
    {
        coinsCount += count;
    }

    void Update()
    {
        porteMonnaie.text = coinsCount.ToString();
    }

    public int GetCoinsCount()
    {
        return coinsCount;
    }

    public void SetCoinsCount(int coins) {
        coinsCount = coins;
        porteMonnaie.text = coinsCount.ToString();
    }
}
