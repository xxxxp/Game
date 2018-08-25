using UnityEngine;
using UnityEngine.UI;

public enum Panel
{
    GamePanel = 1,
}
public class UIManager:Singleton<UIManager>
{
    private Canvas _uiCanvas;
    private Canvas uiCanvas
    {
        get {
            if (_uiCanvas==null)
            {
                _uiCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();
            }
            return _uiCanvas;
        }
    }

  
    public void CreatePanel<T>(string path)where T:UIBase
    {
        GameObject ass = ResourcesMgr.GetAsset<GameObject>(path);
        GameObject go = GameObject.Instantiate(ass);
        go.AddComponent<T>();
        go.transform.SetParent(uiCanvas.transform);
        RectTransform rt = go.transform as RectTransform;
        rt.localPosition = Vector3.zero;
        rt.localScale = Vector3.one;
        rt.sizeDelta = Vector2.zero;
        go.name = typeof(T).ToString();
    }
}

