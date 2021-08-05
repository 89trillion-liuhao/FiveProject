using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * 金币实体类
 */
public class Glod: MonoBehaviour
{
    
    //金币数量
    private int glodValue;
    //是否被领取
    private bool isReally ;
    //分数
    private int markValue;

    //析构函数
    public Glod()
    {
        glodValue = 200;
        isReally = true;
    }

    public Glod(int markValue,bool isReally)
    {
        glodValue = 200;
        this.markValue = markValue;
        this.isReally = isReally;
    }
    public int GlodValue
    {
            get
            {
                return glodValue;
            }
            set
            {
                glodValue = value;
            }
    }

    public int MarkValue
    {
        get
        {
            return markValue;
        }
        set
        {
            markValue = value;
        }
    }
    public bool IsReally
    {
        get
        {
            return isReally;
        }
        set
        {
            isReally = value;
        }
    }
}
