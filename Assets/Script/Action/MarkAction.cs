using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkAction : MonoBehaviour
{
    public GameObject marker;//分数显示面板
    public GameObject ranker;//段位显示面板
    public DrawCanvas player;
    // Start is called before the first frame update
    void Start()
    {
        player = marker.GetComponent<DrawCanvas>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public  void AddMark()
    {
        player.markNum += 100;
        int rankNum = player.markNum - 3000;
        
        if (rankNum < 0)
        {
            player.rankNum = 0;
        }
        else if(rankNum <= 3000)
        {
            player.rankNum = rankNum / 1000;
        }
    }
    //下个赛季
    public void RefushScene()
    {
        int nowMark = player.markNum - 4000;
        if (nowMark > 0)
        {
            if (nowMark == 1)
            {
                player.markNum = 4000;
            }
            player.markNum -= nowMark/2;
        }
        GameObject[] allGold = GameObject.FindGameObjectsWithTag("Gold");//获取所有金币对象
        foreach (GameObject item in allGold)
        {
            item.GetComponent<Glod>().IsReally = true;
        }
    }
}
