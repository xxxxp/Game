using UnityEngine;



public class ResourcesMgr
{
    public static T GetAsset<T>(string path) where T : UnityEngine.Object
    {
        T t = Resources.Load<T>(path);
        if (t == null)
        {
            Debug.LogWarning(string.Format("res not exist path = {0}", path));
        }
        return t;
    }
    public static GameObject GetPrefab(string path)
    {
        GameObject ass = GetAsset<GameObject>(path);
        GameObject go = GameObject.Instantiate(ass);
        go.name = go.name.Substring(0, go.name.Length - 7);
        return go;
    }
}

