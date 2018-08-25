using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.IO;

public class JsonTool{
    private static Dictionary<string,JObject> jObjects = new Dictionary<string,JObject>();
    public static JObject GetJsonTable(string path)
    {
        if (jObjects.ContainsKey(path))
        {
            return jObjects[path];
        }
        string allText = File.ReadAllText(Application.dataPath+path);
        JObject jo = JObject.Parse(allText);
        if (jo==null)
        {
            Debug.LogWarning("json read error");
            return null;
        }
        jObjects.Add(path, jo);
        return jObjects[path];
    }

    public static void WriteJson()
    {
        
    }
}
