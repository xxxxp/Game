using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public abstract class UIBase:PMono
{
    protected Dictionary<string, Component> uicomponents = new Dictionary<string, Component>();

    private RectTransform _rectT;
    public RectTransform rectT
    {
        get
        {
            if (_rectT==null)
            {
                _rectT = transform as RectTransform;
            }
            return _rectT;
        }
    }

    public virtual void Start()
    {
        gameObject.GetAllComponents(ref uicomponents);
    }
    

    public void CreateChildPanel<T>(string childName,string path)where T:UIBase
    {
        GameObject ass = ResourcesMgr.GetAsset<GameObject>(path);
        GameObject go = GameObject.Instantiate(ass);
        go.AddComponent<T>();
        Transform parentTr = transform;
        if (uicomponents.ContainsKey(childName))
        {
            parentTr = uicomponents[childName].transform;
        }
        go.transform.SetParent(parentTr);
        RectTransform rt = go.transform as RectTransform;
        rt.localPosition = Vector3.zero;
        rt.localScale = Vector3.one;
        rt.sizeDelta = Vector2.zero;
        go.name = typeof(T).ToString();
    }
}

