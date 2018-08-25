using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public static class Ext
{
    /// <summary>
    /// 用于特殊命名的物体
    /// </summary>
    /// <param name="go"></param>
    /// <param name="dic"></param>
    public static void GetAllComponents(this GameObject go, ref Dictionary<string, Component> dic)
    {
        Component com = go.GetNamedComponent();
        if (com != null)
        {
            dic.Add(go.name, com);
        }
        int num = go.transform.childCount;
        for (int i = 0; i < num; i++)
        {
            Transform tr = go.transform.GetChild(i);
            int childNum = tr.childCount;
            if (childNum>0)
            {
                tr.gameObject.GetAllComponents(ref dic);
            }
            else
            {
                Component com1 = tr.gameObject.GetNamedComponent();
                if (com1 != null)
                {
                    dic.Add(com1.gameObject.name, com1);
                }
            }
        }

    }

    public static Component GetNamedComponent(this GameObject go)
    {
        string str = go.name;
        string[] arr = str.Split('_');
        Component com = null;

        if (arr[0] == "Tr")
        {
            com = go.GetComponent<RectTransform>();
        }
        else if (arr[0] == "Im")
        {
            com = go.GetComponent<Image>();
        }
        else if (arr[0] == "Te")
        {
            com = go.GetComponent<Text>();
        }
        else if (arr[0] == "But")
        {
            com = go.GetComponent<Button>();
        }
        else if (arr[0] == "Can")
        {
            com = go.GetComponent<CanvasGroup>();
        }
        else if (arr[0] == "Sli")
        {
            com = go.GetComponent<Slider>();
        }
        else if (arr[0] == "Scr")
        {
            com = go.GetComponent<ScrollRect>();
        }
        else if (arr[0] == "Tog")
        {
            com = go.GetComponent<Toggle>();
        }
        else if (arr[0] == "Dro")
        {
            com = go.GetComponent<Dropdown>();
        }
        else if (arr[0] == "Inp")
        {
            com = go.GetComponent<InputField>();
        }
        return com;
    }
}
