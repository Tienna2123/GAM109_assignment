using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using System.Threading;
using UnityEngine.UI;

[SerializeField]
public class Region
{
    public int ID { get; set; }
    public string Name { get; set; }
    public Region(int ID, string Name)
    {
        this.ID = ID;
        this.Name = Name;
    }
}

[SerializeField]
public class Players
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Score { get; set; }
    public Region PlayerRegion { get; set; }
    public Players(int id, string name, int score, Region region)
    {
        Id = id;
        Name = name;
        Score = score;
        PlayerRegion = region;
    }
}

public class ASM_MN : Singleton<ASM_MN>
{
    public List<Region> listRegion = new List<Region>();
    public List<Players> listPlayer = new List<Players>();

    private void Start()
    {
        createRegion();
    }

    public void createRegion()
    {
        listRegion.Add(new Region(0, "VN"));
        listRegion.Add(new Region(1, "VN1"));
        listRegion.Add(new Region(2, "VN2"));
        listRegion.Add(new Region(3, "JS"));
        listRegion.Add(new Region(4, "VS"));
    }

    public string calculate_rank(int score)
    {

        // sinh viên viết tiếp code ở đây
        return null;
    }

    public void YC1()
    {
        string name = ScoreKeeper.Instance.GetUserName();
        int id = ScoreKeeper.Instance.GetID();
        int idR = ScoreKeeper.Instance.GetIDregion();

        int score = ScoreKeeper.Instance.GetScore();
        string regionName = "";

        if(idR == 0)
        {
            regionName ="VN";
        }else if(idR == 1)
        {
            regionName = "VN1";
        }else if(idR == 2)
        {
            regionName = "VN2";
        }else if(idR == 3)
        {
            regionName = "JS";
        }else if (idR == 4)
        {
            regionName = "VS";
        }

        

        Region playerRegion1 = new Region(idR, regionName);
        Players player3 = new Players(id, name, score, playerRegion1);
        listPlayer.Add(player3);
    }
    public void YC2()
    {
        foreach (Players player in listPlayer)
        {
            Debug.Log("Player Name: " + player.Name + " - Score: " + player.Score + "- Region: " + player.PlayerRegion.Name);
        }
    }
    public void YC3()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC4()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC5()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC6()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC7()
    {
        // sinh viên viết tiếp code ở đây
    }
    void CalculateAndSaveAverageScoreByRegion()
    {
        // sinh viên viết tiếp code ở đây
    }

}

