using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class IdleGame : MonoBehaviour
{
    //UI
    public Text coinsText;
    public Text coinsPerSecText;
    public Text clickValueText;
    public double coins;
    public double clickValue;
    public double coinsPerSec;
    
    //Clicker upg   1
    public Text clickerUpgText;
    public double clickerUpgCost;
    public int clickerUpgLvl1;
    public double clickerPower;
    public Image ProgresBarClicekrUpg;
    
    //Clicker upg   2
    public Text clickerUpg2Text;
    public double clickerUpg2Cost;
    public int clickerUpg2Lvl1;
    public double clickerPower2;
    public Image ProgresBarClicekrUpg2;
    
    //auto click 
    public double autoClickUpgCost;
    public int autoClickUpgLvl;
    public Text autoClickText;
    public double autoClick1Power;
    public Image ProgresBarAutoClickUpg; 
    
    //auto clicker 2
    public double autoClickUpg2Cost;
    public int autoClickUpg2Lvl;
    public Text autoClick2Text;
    public double autoClick2Power;
    public Image ProgresBarAutoClickUpg2; 
    
    //GEMS
    public Text gemsText;
    public Text boostText;
    public Text toGetGemsText;
    public double gems;
    public double boost;
    public double toGetGems;
    public double gemShop;
    //GEMSHOP
    public double autoClickerGemLvl;
    public double autoClickerGemCost;
    public double autoClickerGemPower;
    public Text autoClickerGemText;
    public Image GemProgresBarAutoClickUpg;
    public bool gemFirstBuy = false;

    
    
    
    
    

    public void Start()
    {
        Load();
    }

    public void Load()
    {
        coins = double.Parse(PlayerPrefs.GetString("coins","0"));
        clickValue = double.Parse(PlayerPrefs.GetString("clickValue", "1"));
        clickerUpgCost = double.Parse(PlayerPrefs.GetString("clickerUpgCost", "15"));
        clickerUpg2Cost = double.Parse(PlayerPrefs.GetString("clickerUpg2Cost", "75"));
        autoClickUpgCost = double.Parse(PlayerPrefs.GetString("autoClickUpgCost", "75"));
        autoClickUpg2Cost = double.Parse(PlayerPrefs.GetString("autoClickUpg2Cost", "150"));
        autoClick1Power = double.Parse(PlayerPrefs.GetString("autoClick1Power", "1"));
        autoClick2Power = double.Parse(PlayerPrefs.GetString("autoClick2Power", "5"));
        clickerPower = double.Parse(PlayerPrefs.GetString("clickerPower", "1"));
        clickerPower2 = double.Parse(PlayerPrefs.GetString("clickerPower2", "5"));
        autoClickerGemLvl = double.Parse(PlayerPrefs.GetString("autoClickerGemLvl", "0"));
        autoClickerGemCost = double.Parse(PlayerPrefs.GetString("autoClickerGemCost", "5"));
        autoClickerGemPower = double.Parse(PlayerPrefs.GetString("autoClickerGemPower", "20"));
        

        clickerUpgLvl1 = PlayerPrefs.GetInt("clickerUpgLvl1", 0);
        clickerUpg2Lvl1 = PlayerPrefs.GetInt("clickerUpg2Lvl1", 0);
        autoClickUpgLvl = PlayerPrefs.GetInt("autoClickUpgLvl", 0);
        autoClickUpg2Lvl = PlayerPrefs.GetInt("autoClickUpg2Lvl", 0);

        gems = double.Parse(PlayerPrefs.GetString("gemShop", "0"));
        boost = double.Parse(PlayerPrefs.GetString("boost", "0"));
        toGetGems = double.Parse(PlayerPrefs.GetString("toGetGems", "0"));
        
        gemFirstBuy = PlayerPrefs.GetInt("gemFirstBuy")==1?true:false;
}

    public void Save()
    {
        PlayerPrefs.SetString("coins", coins.ToString());
        PlayerPrefs.SetString("clickValue", clickValue.ToString());
        PlayerPrefs.SetString("clickerUpgCost", clickerUpgCost.ToString());
        PlayerPrefs.SetString("clickerUpg2Cost", clickerUpg2Cost.ToString());
        PlayerPrefs.SetString("autoClickUpgCost", autoClickUpgCost.ToString());
        PlayerPrefs.SetString("autoClickUpg2Cost", autoClickUpg2Cost.ToString());
        PlayerPrefs.SetString("autoClick1Power", autoClick1Power.ToString());
        PlayerPrefs.SetString("autoClick2Power", autoClick2Power.ToString());
        PlayerPrefs.SetString("clickerPower", clickerPower.ToString());
        PlayerPrefs.SetString("clickerPower2", clickerPower2.ToString());
        PlayerPrefs.SetString("autoClickerGemPower", autoClickerGemPower.ToString());
        PlayerPrefs.SetString("autoClickerGemCost", autoClickerGemCost.ToString());
        PlayerPrefs.SetString("autoClickerGemLvl", autoClickerGemLvl.ToString());

        PlayerPrefs.SetInt("clickerUpgLvl1", clickerUpgLvl1);
        PlayerPrefs.SetInt("clickerUpg2Lvl1", clickerUpg2Lvl1);
        PlayerPrefs.SetInt("autoClickUpgLvl", autoClickUpgLvl);
        PlayerPrefs.SetInt("autoClickUpg2Lvl", autoClickUpg2Lvl);

        PlayerPrefs.SetString("gems", gems.ToString());
        PlayerPrefs.SetString("gemShop", gemShop.ToString());
        PlayerPrefs.SetString("boost", boost.ToString());
        PlayerPrefs.SetString("toGetGems", toGetGems.ToString());
        
        PlayerPrefs.SetInt("gemFirstBuy", gemFirstBuy?1:0);

    }


    /*
    [MenuItem("Window/Delete PlayerPrefs (All)")]                                          //Delete prefs
    static void DeleteAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
    */



    public void Update()
    {

        toGetGems = (150 * System.Math.Sqrt(coins / 1e8));
        toGetGemsText.text = "PRESTIGE\n+" + toGetGems.ToString("F1") + " GEMS";
        gemsText.text = "Gems: " + gemShop.ToString("F1");
        boostText.text = boost.ToString("F2") + "x BOOST";

        coinsPerSec = ((autoClick1Power * autoClickUpgLvl) + (autoClick2Power * autoClickUpg2Lvl)) + (autoClickerGemPower * autoClickerGemLvl) * boost;
        coinsPerSecText.text = coinsPerSec.ToString("F2") + " Coins/Sec";
        autoClickerGemText.text = "+" + (autoClickerGemPower * boost).ToString("F2") + "\nCost: " + autoClickerGemCost.ToString("F0") + "\n Lvl: " + autoClickerGemLvl;
        
        
        if (clickValue > 10000)
        {
            var exponent =(System.Math.Floor(System.Math.Log10(System.Math.Abs(clickValue)))); 
            var mantissa = (clickValue / System.Math.Pow(10, exponent));
            clickValueText.text = "Click\n+" + mantissa.ToString("F0") + "-e" + exponent; 
        }
        else
            clickValueText.text ="Click\n+" + clickValue.ToString("F0");

        if (coins > 10000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(coins))));
            var mantissa = (coins / System.Math.Pow(10, exponent));
            coinsText.text = "Coins: " + mantissa.ToString("F2") + "-e" + exponent;
        }
        else
            coinsText.text = "Coins: " + coins.ToString("F0");
        
        if (clickerUpgCost > 10000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(clickerUpgCost))));
            var mantissa = (clickerUpgCost / System.Math.Pow(10, exponent));
            clickerUpgText.text = "Click +" + (clickerPower * boost).ToString("F2") + "\nCost: " + mantissa.ToString("F2") + "-e" + exponent + "\n Lvl: " + clickerUpgLvl1;
        }
        else
            clickerUpgText.text = "Click +" + (clickerPower * boost).ToString("F2") + "\nCost: " + clickerUpgCost.ToString("F0") + "\n Lvl: " + clickerUpgLvl1;
        
        if (clickerUpg2Cost > 10000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(clickerUpg2Cost))));
            var mantissa = (clickerUpg2Cost / System.Math.Pow(10, exponent));
            clickerUpg2Text.text = "Click +" + (clickerPower2 * boost).ToString("F2") + "\nCost: " + mantissa.ToString("F2") + "-e" + exponent + "\n Lvl: " + clickerUpg2Lvl1;
        }
        else
            clickerUpg2Text.text = "Click +" + (clickerPower2 * boost).ToString("F2") + "\nCost: " + clickerUpg2Cost.ToString("F0") + "\n Lvl: " + clickerUpg2Lvl1;
        
        if (autoClickUpgCost > 10000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(autoClickUpgCost))));
            var mantissa = (autoClickUpgCost / System.Math.Pow(10, exponent));
            autoClickText.text = "+" + boost.ToString("F2") + "C/Sec\nCost: " + mantissa.ToString("F2") + "-e" + exponent + "\n Lvl: " + autoClickUpgLvl;
        }
        else
            autoClickText.text = "+" + boost.ToString("F2") + " C/Sec\nCost: " + autoClickUpgCost.ToString("F0") + "\n Lvl: " + autoClickUpgLvl;
        
        if (autoClickUpg2Cost > 10000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(autoClickUpg2Cost))));
            var mantissa = (autoClickUpg2Cost / System.Math.Pow(10, exponent));
            autoClick2Text.text = "+" + (autoClick2Power * boost).ToString("F2") + "C/Sec\nCost: " + mantissa.ToString("F2") + "-e" + exponent + "\n Lvl: " + autoClickUpg2Lvl;
        }
        else
            autoClick2Text.text = "+" + (autoClick2Power * boost).ToString("F2") + " C/Sec\nCost: " + autoClickUpg2Cost.ToString("F0") + "\n Lvl: " + autoClickUpg2Lvl;




        //ProgresBars
        ProgresBarClicekrUpg.fillAmount = (float)(coins / clickerUpgCost);
        ProgresBarClicekrUpg2.fillAmount = (float)(coins / clickerUpg2Cost);
        ProgresBarAutoClickUpg.fillAmount = (float)(coins / autoClickUpgCost);
        ProgresBarAutoClickUpg2.fillAmount = (float)(coins / autoClickUpg2Cost);

        if (gemFirstBuy)
        {
            GemProgresBarAutoClickUpg.fillAmount = (float)(gemShop / autoClickerGemCost);
        }
        else
        {
            GemProgresBarAutoClickUpg.fillAmount = (float)(toGetGems / autoClickerGemCost);
        }
        
        
        coins += coinsPerSec * Time.deltaTime;
        Save();
    }

    public void Click()
    {
        coins += clickValue;
    }

    public void Prestige()
    {
        if (coins > 750) 
        {
            
            coins = 0;
            clickValue = 1;
            clickerUpgCost = 15;
            clickerUpg2Cost = 75;
            autoClickUpgCost = 75;
            autoClickUpg2Cost = 150;
            autoClick1Power = 1;
            autoClick2Power = 5;
            clickerPower = 1;
            clickerPower2 = 5;

            clickerUpgLvl1 = 0;
            clickerUpg2Lvl1 = 0;
            autoClickUpgLvl = 0;
            autoClickUpg2Lvl = 0;
            gems += toGetGems;
            boost = (gems * 0.01) + 1;
            gemShop += toGetGems;
            gemFirstBuy = true;

        }
    }


        //Upgrades
        //CLICKER
    public void BuyClickerUpg()
    {
        if (coins >= clickerUpgCost)
        {
            clickerUpgLvl1++;
            coins -= clickerUpgCost;
            clickerUpgCost *= 1.06;
            clickValue = clickValue + (clickerPower * boost);
        }

    }

    public void BuyClickerUpg2()
    {
        if (coins >= clickerUpg2Cost)
        {
            clickerUpg2Lvl1++;
            coins -= clickerUpg2Cost;
            clickerUpg2Cost *= 1.10;
            clickValue = clickValue + (clickerPower2 * boost);
            
        }

    }
    //AUTOCLICK
    public void BuyAutoClickUpg()
    {
        if (coins >= autoClickUpgCost)
        {
            autoClickUpgLvl++;
            coins -= autoClickUpgCost;
            autoClickUpgCost *= 1.07;

        }

    }
    public void BuyAutoClickUpg2()
    {
        if (coins >= autoClickUpg2Cost)
        {
            autoClickUpg2Lvl++;
            coins -= autoClickUpg2Cost;
            autoClickUpg2Cost *= 1.10;

        }

    }
    public void BuyGemAutoClick()
    {
        if (gemShop >= autoClickerGemCost)
        {
            autoClickerGemLvl++;
            gemShop -= autoClickerGemCost;
            autoClickerGemCost *= 1.15;

        }

    }
}
