using System;
using UnityEngine;

internal class LevelDifficulty
{
    //These are all of the levels
    public GameObject Easy1;
    public GameObject Easy2;
    public GameObject Med1;
    public GameObject Med2;
    public GameObject Hard1;
    public GameObject Hard2;

    public string level;
    public int NoOfAbilities;
    public int difficulty;
    public int damage;
    public int room;

    void Start()
    {
        difficulty = (1 + NoOfAbilities) / damage;
        if (Completed == True)
        {
            System.Random rnd = new System.Random();
            if (difficulty <= 3)
            {
                room = rnd.Next(0, 2);
            }
            else if (difficulty >= 5)
            {
                room = rnd.Next(0, 6);
            }
            else
            {
                room = rnd.Next(0, 4);
            }
        }
    }
}
