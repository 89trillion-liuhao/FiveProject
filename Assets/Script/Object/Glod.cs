using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * 金币实体类
 */
public class Glod
{
    
    
    private int glodValue;
    private bool isReally;

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
