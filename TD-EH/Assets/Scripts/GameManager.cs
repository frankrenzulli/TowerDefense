using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int money = 0;
    public int startMoney = 200;
    public int baseHP = 100;
    public GameObject LoseScreen;
    public TextMeshProUGUI MoneyText;
    public TextMeshProUGUI BaseHpText;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        Time.timeScale = 1f;
        money = startMoney;
    }

    private void Update()
    {
        if(baseHP <= 0)
        {
            Time.timeScale = 0f;
            LoseScreen.SetActive(true);
        }
        MoneyText.text = money.ToString() + "$";
        BaseHpText.text = "HP BASE: " + baseHP.ToString();
        Debug.Log(money);
    }

    public void AddMoney(int add)
    {
        money += add;
    }
    public void RemoveMoney(int remove)
    {
        money -=remove;
    }
    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
