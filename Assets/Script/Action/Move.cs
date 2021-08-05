using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Debug = UnityEngine.Debug;

public class Move : MonoBehaviour
{
    

    public GameObject tranContent;

    public DrawCanvas player;
    public GameObject marker;
    // Start is called before the first frame update
    void Start()
    {
        player = marker.GetComponent<DrawCanvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        
            
            int nowMarkNum = player.markNum;
            if (nowMarkNum <= 4000)
            {
                tranContent.transform.localPosition = new Vector3(200, 100, 0);
            }
            else if (nowMarkNum > 6000)
            {
                tranContent.transform.localPosition = new Vector3(200, 3000, 0);
            }
            else
            {
                nowMarkNum -= 4000;
                nowMarkNum = nowMarkNum / 200 * 200;
                tranContent.transform.localPosition = new Vector3(200,nowMarkNum,0);
            }


    }
}
