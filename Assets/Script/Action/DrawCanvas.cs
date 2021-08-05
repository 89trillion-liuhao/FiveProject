using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * 初始化界面 
 */
public class DrawCanvas : MonoBehaviour
{
    public GameObject canvas;
    public GameObject goldGameObject;
    public int thisMark = 8;//8个奖励模块
    public Text markNumText;//展示分数的地方
    public Text rankNumText;//展示分数的地方
    public int markNum = 0;//目前的分数
    public int rankNum = 0;//目前段位
    public int goldValue= 0;//金币数量
    public Text goldText;
    private int goldMarkValue = 5600 ;//金币段位分
    // Start is called before the first frame update
    private int posY = -500;//y坐标
    void Start()
    {
        CreateMainCanvas();
    }

    // Update is called once per frame
    void Update()
    {

        markNumText.text = markNum.ToString();//设置当前的分数
        if (rankNum > 0)
        {
            rankNumText.text = "当前段位："+rankNum+"段";
        }
        else
        {
            rankNumText.text = "当前无段位";
        }

        goldText.text = goldValue.ToString();
    }

    //画页面
    void CreateMainCanvas()
    {
        for (int i = thisMark ; i > 0;i--)
        {
            // GameObject thisObject = Instantiate(Resources.Load("GoldObject")) as GameObject;
             GameObject thisObject = Instantiate(goldGameObject) as GameObject;
            
            
            thisObject.transform.SetParent(canvas.transform);
            thisObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(664.04f,posY*i);
            //赋值
            thisObject.GetComponent<Glod>().MarkValue = goldMarkValue;
            // if ( goldMarkValue % 1000 != 0)
            // {
            //     goldMarkValue -= 200;
            // }
            // else
            // {
            //     goldMarkValue -= 400;
            // }
            goldMarkValue -= 200;

            
           
        }
    }

    
}
