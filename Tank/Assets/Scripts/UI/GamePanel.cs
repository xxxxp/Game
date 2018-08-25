using System;
using UnityEngine;

public class GamePanel:UIBase
{
    public override void Start()
    {
        base.Start();
        CreateMap(12,16);
    }

    private void CreateMap(int row,int column)
    {
        float width = rectT.rect.width/ column;
        float height = rectT.rect.height/row;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                GameObject go = ResourcesMgr.GetPrefab("Prefabs/Grid");
                RectTransform tr = go.transform as RectTransform;
                tr.SetParent(transform);
                tr.sizeDelta = new Vector2(width, height);
                tr.anchorMin = Vector2.zero;
                tr.anchorMax = Vector2.zero;
                tr.localPosition = new Vector3(j * width- rectT.rect.width/2, i * height- rectT.rect.height/2, 0);
                tr.localScale = Vector3.one;
            }
        }
        
    }
}
