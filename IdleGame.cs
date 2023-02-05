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
    
    //Clicker upg   3
    public Text clickerUpg3Text;
    public double clickerUpg3Cost;
    public int clickerUpg3Lvl1;
    public double clickerPower3;
    public Image ProgresBarClicekrUpg3;
    
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
    //auto clicker 3
    public double autoClickUpg3Cost;
    public int autoClickUpg3Lvl;
    public Text autoClick3Text;
    public double autoClick3Power;
    public Image ProgresBarAutoClickUpg3; 
    
    //GEMS
    public Text gemsText;
    public Text boostText;
    public Text toGetGemsText;
    public double gems;
    public double boost;
    public double toGetGems;
    public double gemShop;
    //GEMSHOP
    
    //CLICKER BOOST
    public Text clickerGemBoostText;
    public Image clickerGemBoostProgresBar;
    public double clickerGemBoostCost;
    public double clickerGemBoostLvl;
    public double clickerGemBoostPower;
    public double help;
    //AUTOCLICK BOOST
    public Text AutoGemBoostText;
    public Image AutoGemBoostProgresBar;
    public double AutoGemBoostCost;
    public double AutoGemBoostLvl;
    public double AutoGemBoostPower;
    public double help2;
    
    
    
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
        clickerUpg2Cost = double.Parse(PlayerPrefs.GetString("clickerUpg2Cost", "175"));
        clickerUpg3Cost = double.Parse(PlayerPrefs.GetString("clickerUpg3Cost", "250"));
        
        autoClickUpgCost = double.Parse(PlayerPrefs.GetString("autoClickUpgCost", "50"));
        autoClickUpg2Cost = double.Parse(PlayerPrefs.GetString("autoClickUpg2Cost", "150"));
        autoClickUpg3Cost = double.Parse(PlayerPrefs.GetString("autoClickUpg3Cost", "200"));
        
        autoClick1Power = double.Parse(PlayerPrefs.GetString("autoClick1Power", "5"));
        autoClick2Power = double.Parse(PlayerPrefs.GetString("autoClick2Power", "10"));
        autoClick3Power = double.Parse(PlayerPrefs.GetString("autoClick3Power", "15"));
        
        clickerPower = double.Parse(PlayerPrefs.GetString("clickerPower", "1"));
        clickerPower2 = double.Parse(PlayerPrefs.GetString("clickerPower2", "5"));
        clickerPower3 = double.Parse(PlayerPrefs.GetString("clickerPower3", "15"));
        
        clickerGemBoostLvl = double.Parse(PlayerPrefs.GetString("clickerGemBoostLvl", "0"));
        clickerGemBoostPower = double.Parse(PlayerPrefs.GetString("clickerGemBoostPower", "0"));
        clickerGemBoostCost = double.Parse(PlayerPrefs.GetString("clickerGemBoostCost", "5"));
        
        help = double.Parse(PlayerPrefs.GetString("help", "1"));
        help2 = double.Parse(PlayerPrefs.GetString("help2", "1"));
        
        AutoGemBoostLvl = double.Parse(PlayerPrefs.GetString("AutoGemBoostLvl", "0"));
        AutoGemBoostPower = double.Parse(PlayerPrefs.GetString("AutoGemBoostPower", "0"));
        AutoGemBoostCost = double.Parse(PlayerPrefs.GetString("AutoGemBoostCost", "8"));

        
        

        clickerUpgLvl1 = PlayerPrefs.GetInt("clickerUpgLvl1", 0);
        clickerUpg2Lvl1 = PlayerPrefs.GetInt("clickerUpg2Lvl1", 0);
        clickerUpg3Lvl1 = PlayerPrefs.GetInt("clickerUpg3Lvl1", 0);
        
        autoClickUpgLvl = PlayerPrefs.GetInt("autoClickUpgLvl", 0);
        autoClickUpg2Lvl = PlayerPrefs.GetInt("autoClickUpg2Lvl", 0);
        autoClickUpg3Lvl = PlayerPrefs.GetInt("autoClickUpg3Lvl", 0);

        gems = double.Parse(PlayerPrefs.GetString("gems", "0"));
        boost = double.Parse(PlayerPrefs.GetString("boost", "1"));
        toGetGems = double.Parse(PlayerPrefs.GetString("toGetGems", "0"));
        gemShop = double.Parse(PlayerPrefs.GetString("gemShop", "0"));
        
        gemFirstBuy = PlayerPrefs.GetInt("gemFirstBuy")==1?true:false;
}

    public void Save()
    {
        PlayerPrefs.SetString("coins", coins.ToString());
        PlayerPrefs.SetString("clickValue", clickValue.ToString());
        PlayerPrefs.SetString("clickerUpgCost", clickerUpgCost.ToString());
        PlayerPrefs.SetString("clickerUpg2Cost", clickerUpg2Cost.ToString());
        PlayerPrefs.SetString("clickerUpg3Cost", clickerUpg3Cost.ToString());
        
        PlayerPrefs.SetString("autoClickUpgCost", autoClickUpgCost.ToString());
        PlayerPrefs.SetString("autoClickUpg2Cost", autoClickUpg2Cost.ToString());
        PlayerPrefs.SetString("autoClickUpg3Cost", autoClickUpg3Cost.ToString());
        
        PlayerPrefs.SetString("autoClick1Power", autoClick1Power.ToString());
        PlayerPrefs.SetString("autoClick2Power", autoClick2Power.ToString());
        PlayerPrefs.SetString("autoClick3Power", autoClick3Power.ToString());
        
        PlayerPrefs.SetString("clickerPower", clickerPower.ToString());
        PlayerPrefs.SetString("clickerPower2", clickerPower2.ToString());
        PlayerPrefs.SetString("clickerPower3", clickerPower3.ToString());
        
        PlayerPrefs.SetString("clickerGemBoostCost", clickerGemBoostCost.ToString());
        PlayerPrefs.SetString("clickerGemBoostLvl", clickerGemBoostLvl.ToString());
        PlayerPrefs.SetString("clickerGemBoostPower", clickerGemBoostPower.ToString());
        
        PlayerPrefs.SetString("AutoGemBoostCost", AutoGemBoostCost.ToString());
        PlayerPrefs.SetString("AutoGemBoostLvl", AutoGemBoostLvl.ToString());
        PlayerPrefs.SetString("AutoGemBoostPower", AutoGemBoostPower.ToString());

        PlayerPrefs.SetInt("clickerUpgLvl1", clickerUpgLvl1);
        PlayerPrefs.SetInt("clickerUpg2Lvl1", clickerUpg2Lvl1);
        PlayerPrefs.SetInt("clickerUpg3Lvl1", clickerUpg3Lvl1);
        
        PlayerPrefs.SetInt("autoClickUpgLvl", autoClickUpgLvl);
        PlayerPrefs.SetInt("autoClickUpg2Lvl", autoClickUpg2Lvl);
        PlayerPrefs.SetInt("autoClickUpg3Lvl", autoClickUpg3Lvl);

        PlayerPrefs.SetString("gems", gems.ToString());
        PlayerPrefs.SetString("gemShop", gemShop.ToString());
        PlayerPrefs.SetString("boost", boost.ToString());
        PlayerPrefs.SetString("toGetGems", toGetGems.ToString());
        
        PlayerPrefs.SetInt("gemFirstBuy", gemFirstBuy?1:0);
        
        PlayerPrefs.SetString("help", help.ToString());
        PlayerPrefs.SetString("help2", help.ToString());

    }

    [MenuItem("Window/Delete PlayerPrefs (All)")]                                          //Delete prefs
    static void DeleteAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }




    public void Update()
    {

        if (clickerGemBoostLvl == 0)
        {
            help = 1;
        }
        else
        {
            help = 0;
        }
        
        toGetGems = (150 * System.Math.Sqrt(coins / 1e7));
        toGetGemsText.text = "PRESTIGE\n+" + toGetGems.ToString("F1") + " GEMS";
        gemsText.text = "Gems: " + gemShop.ToString("F1");
        boostText.text = boost.ToString("F2") + "x BOOST";
       
        coinsPerSec = ((autoClick1Power * autoClickUpgLvl) + (autoClick2Power * autoClickUpg2Lvl) + (autoClick3Power * autoClickUpg3Lvl)) * boost / (help2 +(AutoGemBoostPower * AutoGemBoostLvl));
        coinsPerSecText.text = coinsPerSec.ToString("F2") + " Coins/Sec";
        //autoClickerGemText.text = "+" + (autoClickerGemPower * boost).ToString("F2") + "C/sec\nCost: " + autoClickerGemCost.ToString("F0") + "  Lvl: " + autoClickerGemLvl;
        
        clickerGemBoostText.text = "Clicker Upgrade \n+5% Click value\nCost: " + clickerGemBoostCost.ToString("F0") + "  Lvl: " + clickerGemBoostLvl;
        AutoGemBoostText.text = "AutoClick Upgrade \n+5% Click value\nCost: " + AutoGemBoostCost.ToString("F0") + "  Lvl: " + AutoGemBoostLvl;
        
        
        if (clickValue > 10000)
        {
            var exponent =(System.Math.Floor(System.Math.Log10(System.Math.Abs(clickValue)))); 
            var mantissa = (clickValue / System.Math.Pow(10, exponent));
            clickValueText.text = "Click \n+" + mantissa.ToString("F0") + "-e" + exponent; 
        }
        else
            clickValueText.text ="Click \n+" + clickValue.ToString("F0");

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
            clickerUpgText.text = "Click +" + (((((clickerPower * boost) / 100) * (5 * (clickerGemBoostLvl + help)))) * 100).ToString("F2") + "\nCost: " + mantissa.ToString("F2") + "-e" + exponent + "  Lvl: " + clickerUpgLvl1;
        }
        else
            clickerUpgText.text = "Click +" + (((((clickerPower * boost) / 100) * (5 * (clickerGemBoostLvl + help)))) * 100).ToString("F2") + "\nCost: " + clickerUpgCost.ToString("F0") + "  Lvl: " + clickerUpgLvl1;
        
        if (clickerUpg2Cost > 10000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(clickerUpg2Cost))));
            var mantissa = (clickerUpg2Cost / System.Math.Pow(10, exponent));
            clickerUpg2Text.text = "Click +" + (clickerPower2 * boost * clickerGemBoostPower * (clickerGemBoostLvl + help)).ToString("F2") + "\nCost: " + mantissa.ToString("F2") + "-e" + exponent + "  Lvl: " + clickerUpg2Lvl1;
        }
        else
            clickerUpg2Text.text = "Click +" + (clickerPower2 * boost * clickerGemBoostPower * (clickerGemBoostLvl + help)).ToString("F2") + "\nCost: " + clickerUpg2Cost.ToString("F0") + "  Lvl: " + clickerUpg2Lvl1;
       
        if (clickerUpg3Cost > 10000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(clickerUpg3Cost))));
            var mantissa = (clickerUpg3Cost / System.Math.Pow(10, exponent));
            clickerUpg3Text.text = "Click +" + (clickerPower3 * boost * clickerGemBoostPower * (clickerGemBoostLvl + help)).ToString("F2") + "\nCost: " + mantissa.ToString("F2") + "-e" + exponent + "  Lvl: " + clickerUpg3Lvl1;
        }
        else
            clickerUpg3Text.text = "Click +" + (clickerPower3 * boost * clickerGemBoostPower * (clickerGemBoostLvl + help)).ToString("F2") + "\nCost: " + clickerUpg3Cost.ToString("F0") + "  Lvl: " + clickerUpg3Lvl1;
        
        if (autoClickUpgCost > 10000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(autoClickUpgCost))));
            var mantissa = (autoClickUpgCost / System.Math.Pow(10, exponent));
            autoClickText.text = "+" + (autoClick1Power * boost * AutoGemBoostPower * (help2 + AutoGemBoostLvl)).ToString("F2") + "C/Sec\nCost: " + mantissa.ToString("F2") + "-e" + exponent + "  Lvl: " + autoClickUpgLvl;
        }
        else
            autoClickText.text = "+" + (autoClick1Power * boost * AutoGemBoostPower * (help2 + AutoGemBoostLvl)).ToString("F2") + " C/Sec\nCost: " + autoClickUpgCost.ToString("F0") + "  Lvl: " + autoClickUpgLvl;
        
        if (autoClickUpg2Cost > 10000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(autoClickUpg2Cost))));
            var mantissa = (autoClickUpg2Cost / System.Math.Pow(10, exponent));
            autoClick2Text.text = "+" + (autoClick2Power * boost * AutoGemBoostPower * (help2 + AutoGemBoostLvl)).ToString("F2") + "C/Sec\nCost: " + mantissa.ToString("F2") + "-e" + exponent + "  Lvl: " + autoClickUpg2Lvl;
        }
        else
            autoClick2Text.text = "+" + (autoClick2Power * boost * AutoGemBoostPower * (help2 + AutoGemBoostLvl)).ToString("F2") + " C/Sec\nCost: " + autoClickUpg2Cost.ToString("F0") + "  Lvl: " + autoClickUpg2Lvl;
        
        if (autoClickUpg3Cost > 10000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(autoClickUpg3Cost))));
            var mantissa = (autoClickUpg3Cost / System.Math.Pow(10, exponent));
            autoClick3Text.text = "+" + (autoClick3Power * boost * AutoGemBoostPower * (help2 + AutoGemBoostLvl)).ToString("F2") + "C/Sec\nCost: " + mantissa.ToString("F2") + "-e" + exponent + "  Lvl: " + autoClickUpg3Lvl;
        }
        else
            autoClick3Text.text = "+" + (autoClick3Power * boost * AutoGemBoostPower * (help2 + AutoGemBoostLvl)).ToString("F2") + " C/Sec\nCost: " + autoClickUpg3Cost.ToString("F0") + "  Lvl: " + autoClickUpg3Lvl;
        



        //ProgresBars
        ProgresBarClicekrUpg.fillAmount = (float)(coins / clickerUpgCost);
        ProgresBarClicekrUpg2.fillAmount = (float)(coins / clickerUpg2Cost);
        ProgresBarClicekrUpg3.fillAmount = (float)(coins / clickerUpg3Cost);
        ProgresBarAutoClickUpg.fillAmount = (float)(coins / autoClickUpgCost);
        ProgresBarAutoClickUpg2.fillAmount = (float)(coins / autoClickUpg2Cost);
        ProgresBarAutoClickUpg3.fillAmount = (float)(coins / autoClickUpg3Cost);

        if (gemFirstBuy)
        {
            clickerGemBoostProgresBar.fillAmount = (float)(gemShop / clickerGemBoostCost);
        }
        else
        {
            clickerGemBoostProgresBar.fillAmount = (float)(toGetGems / clickerGemBoostCost);
        }
        
        if (gemFirstBuy)
        {
            AutoGemBoostProgresBar.fillAmount = (float)(gemShop / AutoGemBoostCost);
        }
        else
        {
            AutoGemBoostProgresBar.fillAmount = (float)(toGetGems / AutoGemBoostCost);
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
        if (coins >1500) 
        {
            
            coins = 0;
            clickValue = 1;
            clickerUpgCost = 15;
            clickerUpg2Cost = 175;
            clickerUpg3Cost = 250;
            autoClickUpgCost = 75;
            autoClickUpg2Cost = 150;
            autoClickUpg3Cost = 200;
            autoClick1Power = 1;
            autoClick2Power = 5;
            autoClick3Power = 15;
            clickerPower = 1;
            clickerPower2 = 5;
            clickerPower3 = 15;

            clickerUpgLvl1 = 0;
            clickerUpg2Lvl1 = 0;
            clickerUpg3Lvl1 = 0;
            autoClickUpgLvl = 0;
            autoClickUpg2Lvl = 0;
            autoClickUpg3Lvl = 0;
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
            clickValue = clickValue + (clickerPower * boost * clickerGemBoostPower * (clickerGemBoostLvl + help));
        }

    }

    public void BuyMaxClicker1()
    {
        while (coins >= clickerUpgCost)
        {
            clickerUpgLvl1++;
            coins -= clickerUpgCost;
            clickerUpgCost *= 1.06;
            clickValue = clickValue + (clickerPower * boost * clickerGemBoostPower * (clickerGemBoostLvl + help));
        }
    }

    public void BuyClickerUpg2()
    {
        if (coins >= clickerUpg2Cost)
        {
            clickerUpg2Lvl1++;
            coins -= clickerUpg2Cost;
            clickerUpg2Cost *= 1.10;
            clickValue = clickValue + (clickerPower2 * boost * clickerGemBoostPower * (clickerGemBoostLvl + help));
            
        }

    }
    
    public void BuyMaxClicker2()
    {
        while (coins >= clickerUpg2Cost)
        {
            clickerUpg2Lvl1++;
            coins -= clickerUpg2Cost;
            clickerUpg2Cost *= 1.10;
            clickValue = clickValue + (clickerPower2 * boost * clickerGemBoostPower * (clickerGemBoostLvl + help));
        }
    }
    
    public void BuyClickerUpg3()
    {
        if (coins >= clickerUpg3Cost)
        {
            clickerUpg3Lvl1++;
            coins -= clickerUpg3Cost;
            clickerUpg3Cost *= 1.10;
            clickValue = clickValue + (clickerPower3 * boost * clickerGemBoostPower * (clickerGemBoostLvl + help));
            
        }

    }
    public void BuyMaxClicker3()
    {
        while (coins >= clickerUpg3Cost)
        {
            clickerUpg3Lvl1++;
            coins -= clickerUpg3Cost;
            clickerUpg3Cost *= 1.10;
            clickValue = clickValue + (clickerPower3 * boost * clickerGemBoostPower * (clickerGemBoostLvl + help));
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
    public void BuyAutoClickUpg3()
    {
        if (coins >= autoClickUpg3Cost)
        {
            autoClickUpg3Lvl++;
            coins -= autoClickUpg3Cost;
            autoClickUpg3Cost *= 1.10;

        }

    }
    public void BuyMaxAuto1()
    {
        while (coins >= autoClickUpgCost)
        {
            autoClickUpgLvl++;
            coins -= autoClickUpgCost;
            autoClickUpgCost *= 1.07;

        }
    }
    public void BuyMaxAuto2()
    {
        while (coins >= autoClickUpg2Cost)
        {
            autoClickUpg2Lvl++;
            coins -= autoClickUpg2Cost;
            autoClickUpg2Cost *= 1.10;

        }
    }
    public void BuyMaxAuto3()
    {
        while (coins >= autoClickUpg3Cost)
        {
            autoClickUpg3Lvl++;
            coins -= autoClickUpg3Cost;
            autoClickUpg3Cost *= 1.10;

        }
    }
    public void BuyClickerGemBoost()
    {
        if (gemShop >= clickerGemBoostCost)
        {
            help = 0;
            clickerGemBoostPower = 1.05;
            clickerGemBoostLvl++;
            gemShop -= clickerGemBoostCost;
            clickerGemBoostCost *= 1.10;
            

        }

    }
    public void BuyAutoGemBoost()
    {
        if (gemShop >= AutoGemBoostCost)
        {
            help2 = 0;
            AutoGemBoostPower = 1.05;
            AutoGemBoostLvl++;
            gemShop -= AutoGemBoostCost;
            AutoGemBoostCost *= 1.10;
            

        }

    }
}
