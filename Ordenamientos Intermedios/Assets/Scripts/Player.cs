using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private string name;
    private int kills;
    private int asists;
    private int deads;
    private int score;
    public string Name { get => name; set => name = value; }
    public int Kills { get => kills; set => kills = value; }
    public int Asists { get => asists; set => asists = value; }
    public int Deads { get => deads; set => deads = value; }
    public int Score { get => score; set => score = value; }

    public Player(string names)
    {
        Name = names;
        kills = Random.Range(0, 30);
        asists = Random.Range(0, 25);
        deads = Random.Range(0, 15);
        CalculateScore();
    }

    private void CalculateScore()
    {
        score = (kills * 3) + (asists * 1) - (deads * 1);
    }
}
