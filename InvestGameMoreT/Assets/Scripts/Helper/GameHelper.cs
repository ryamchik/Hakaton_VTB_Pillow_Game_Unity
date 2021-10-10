using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHelper : MonoBehaviour
{
    public int start_count;
    System.DateTime start_time;
    public GameObject coin;
    public Transform par;
    public int final_count_coins = 0;
    public GameObject win;
    public GameObject lose;
    [SerializeField] private GoldScr _goldScr;
    [SerializeField] private BondsScr _bondsScr;
    [SerializeField] private StockScr _stockScr;
    [SerializeField] private AddingCoin _adding;
    [SerializeField] private DepositScr _depositScr;

    float speed_delta_coin;

    void Start()
    {
        InvokeRepeating("CoinStart", 0f, speed_delta_coin);
        start_time = System.DateTime.Now;
    }

    void CoinStart()
    {
        float pos_y = 4.6f;

        //Instantiate(coins);
        for (int i = 0; i < start_count; i++)
        {

            Vector3 position = new Vector3(Random.Range(-1.5f, 1.5f), pos_y, 0);
            Instantiate(coin, position, Quaternion.identity, par);

            pos_y += 1;
        }
    }

    private void Update()
    {
        if (System.DateTime.Now.Second - start_time.Second == 90)
        {
            Timer();
        }
    }

    void Timer()
    {
        final_count_coins = _goldScr.GoldCoin + _bondsScr.BondCoin + _stockScr.StockCoin + _depositScr.DepositCoin;

        if (final_count_coins > 50)
        {
            win.SetActive(true);
        }
        else
        {
            lose.SetActive(true);
        }
    }

}


