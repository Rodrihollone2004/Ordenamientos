using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreManager : MonoBehaviour
{
    public List<Player> players = new List<Player>();
    public TMP_Text listPlayersText;

    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            players.Add(new Player("Player " + i));
        }
        ShowPlayers();
    }

    public void SortByKills()
    {
        Sort(players, CompareByKills);
        ShowPlayers();
    }

    public void SortByAssists()
    {
        Sort(players, CompareByAssists);
        ShowPlayers();
    }

    public void SortByDeaths()
    {
        Sort(players, CompareByDeaths);
        ShowPlayers();
    }

    public void SortByScore()
    {
        Sort(players, CompareByScore);
        ShowPlayers();
    }
    private void Sort(List<Player> list, System.Func<Player, Player, int> comparer)
    {
        int number = list.Count;
        for (int i = 0; i < number - 1; i++)
        {
            for (int j = 0; j < number - i - 1; j++)
            {
                if (comparer(list[j], list[j + 1]) < 0)
                {
                    Player temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
    }

    private int CompareByKills(Player player1, Player player2)
    {
        return player1.Kills - player2.Kills;
    }

    private int CompareByAssists(Player player1, Player player2)
    {
        return player1.Asists - player2.Asists;
    }

    private int CompareByDeaths(Player player1, Player player2)
    {
        return player2.Deads - player1.Deads;
    }

    private int CompareByScore(Player player1, Player player2)
    {
        return player1.Score - player2.Score;
    }

    private void ShowPlayers()
    {
        listPlayersText.text = "";
        foreach (Player player in players)
        {
            listPlayersText.text += $"{player.Name}: Score: {player.Score}, Kills: {player.Kills}, Assists: {player.Asists}, Deaths: {player.Deads}\n";
        }
    }
}

