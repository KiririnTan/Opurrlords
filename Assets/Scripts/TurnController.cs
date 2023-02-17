using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnController : MonoBehaviour
{
    static readonly int TURN_MAX = 50;

    public int Turn { get; private set; } = 1;

    private int prevTurn = 0;



    //ui
    public TMP_Text turnText;
    public TMP_Text moneyText;
    public TMP_Text experienceText;

    void Start()
    {
        var player = GameObject
        .Find("Player")
        .GetComponent<Player>();
        updateUI(player);
    }

    void Update()
    {
        if (IsTurnChanged())
        {
            Debug.Log("Turn " + Turn);
        }
    }

    bool IsTurnChanged()
    {
        if (Turn != prevTurn)
        {
            prevTurn = Turn;
            return true;
        }
        return false;
    }

    public void NextTurn()
    {
        if (Turn >= TURN_MAX)
        {
            Debug.Log("gameover");
            return;
        }

        this.Turn += 1;

        var player = GameObject
            .Find("Player")
            .GetComponent<Player>();
        player.money += 5;
        player.experience += 1;

        //ui
        updateUI(player);
    }

    public void updateUI(Player player)
    {
        turnText.text = "Turn: " + this.Turn.ToString();
        moneyText.text = "Money: " + player.money.ToString();
        experienceText.text = "Experience: " + player.experience.ToString();
    }
}
