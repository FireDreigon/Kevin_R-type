using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class HUDManager
{
    public Text CurrentPlayerNick;
    public List<GameObject> PlayerLife;
    public Text Hp, Atk, Spd;
    public Text Coins;
    public Text Score, HighScore, LvGame;
    public Text TimeGame;
    public Image ChargeBar;
    public Image CurrentPlayerIcon;

    // Use this for initialization
    public void Start(Player currentPlayer)
    {
        GameObject HUD = GameObject.Find("HUD");
        GameObject PlayerStats = HUD.transform.GetChild(0).gameObject;

        CurrentPlayerNick = PlayerStats.transform.GetChild(2).GetComponent<Text>();
        GameObject TotalLife = PlayerStats.transform.GetChild(2).gameObject;
        for (int i = 0; i < TotalLife.transform.childCount; i++)
            this.PlayerLife.Add(TotalLife.transform.GetChild(i).gameObject);

        GameObject Stats = PlayerStats.transform.GetChild(3).gameObject;
        this.Hp = Stats.transform.GetChild(0).GetChild(0).GetComponent<Text>();
        this.Atk = Stats.transform.GetChild(1).GetChild(0).GetComponent<Text>();
        this.Spd = Stats.transform.GetChild(2).GetChild(0).GetComponent<Text>();

        this.Coins = PlayerStats.transform.GetChild(4).GetChild(0).GetComponent<Text>();
        this.Score = PlayerStats.transform.GetChild(5).GetChild(0).GetComponent<Text>();

        this.ChargeBar = HUD.transform.GetChild(1).GetChild(0).GetComponent<Image>();
        this.HighScore = HUD.transform.GetChild(2).GetChild(0).GetComponent<Text>();

        GameObject ButonAcction = HUD.transform.GetChild(3).gameObject; ;

        this.LvGame = HUD.transform.GetChild(4).GetChild(0).GetComponent<Text>();
        this.TimeGame = HUD.transform.GetChild(5).GetChild(0).GetComponent<Text>();

        UpdatePlayerStats(currentPlayer);
        UpdateChargeBeam();
        UpdateLifePlayer();
        UpdateScore();
        UpdateTime();
    }

    public void UpdatePlayerStats(Player currentPlayer)
    {
        this.Hp.text = currentPlayer.HP.ToString();
        this.Atk.text = Bullet.AtkBullet(currentPlayer.bulletType).ToString();
        this.Spd.text = currentPlayer.HP.ToString();
    }
    public void UpdateChargeBeam(float amount = 0)
    {
        this.ChargeBar.fillAmount = amount;
    }
    public void UpdateScore(int score = 0)
    {
        this.Score.text = score.ToString("00000000000000000000");
    }
    public void UpdateTime(float time = 0)
    {
        string showTime = null;
        if (time >= 3600)
            showTime += ((int)time / 3600).ToString("00") + ":";
        if (time >= 60)
        {
            showTime += (((int)time % 3600) / 60).ToString("00") + ":";
            showTime += (((int)time % 3600) % 60).ToString("00");
            this.TimeGame.text = showTime;
        }
        else
            this.TimeGame.text = time.ToString("0.00") + " s";

    }
    public void UpdateLifePlayer(int currentLife = 2)
    {
        for (int i = 0; i < PlayerLife.Count; i++)
            if (i < currentLife)
                PlayerLife[i].SetActive(true);
            else
                PlayerLife[i].SetActive(false);


    }


}
