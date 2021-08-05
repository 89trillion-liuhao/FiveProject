using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GoldAction : MonoBehaviour
{
    public GameObject playMarkNum;//玩家的分数
    private int beforeMark=0;
    
    
    
    public GameObject marker;//分数显示面板
    private DrawCanvas player;
    
    public GameObject[] allGold;
    // Start is called before the first frame update
    void Start()
    {
        player = marker.GetComponent<DrawCanvas>();
    }

    // Update is called once per frame
    void Update()
    {

        if (beforeMark != player.markNum)
        {
            SetGoldState();
        }
        beforeMark = player.markNum;
    }

    void SetGoldState()
    {
        GameObject[] allGold = GameObject.FindGameObjectsWithTag("Gold");//获取所有金币对象
        foreach (GameObject item in allGold)
        {
            if (item.GetComponent<Glod>().MarkValue <= player.markNum)
            {
                if (item.GetComponent<Glod>().IsReally)//可领取
                {
                    item.gameObject.GetComponentInChildren<Text>().text ="可领取";
                    item.GetComponent<Button>().interactable = true;
                }
                else
                {
                    item.gameObject.GetComponentInChildren<Text>().text ="已领取";
                    item.GetComponent<Button>().interactable = false;
                }
                
            }
            else
            {
                item.gameObject.GetComponentInChildren<Text>().text ="未解锁";
                item.GetComponent<Button>().interactable = false;
            }
            
        }
    }

    public void BtnOnClick()
    {
        Button thisBtn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        //Debug.Log(thisBtn)
        Debug.Log(thisBtn.GetComponent<Glod>());
        ChangeGoldIsReally(thisBtn);
    }
    void ChangeGoldIsReally(Button btn)
    {
        // if (btn.GetComponentInChildren<Text>().Equals(""))
        // {
        //     
        // }
        btn.GetComponent<Glod>().IsReally = false;
        SetGoldState();
        player.GetComponent<DrawCanvas>().goldValue += 100;
        Debug.Log("");
    }
}
