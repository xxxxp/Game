using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testZK : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("zk just do it");
            GetComponent<Text>().text = "zk is a gua pi";
            GetComponent<Text>().fontSize = 48;
        }

	}
}
