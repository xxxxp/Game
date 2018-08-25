using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

    private void Awake()
    {
        
    }

    void Start () {
        StartGame();

    }
	
	// Update is called once per frame
	void Update () {

    }

    void StartGame()
    {
        UIManager.instance.CreatePanel<GameSideUIPanel>("Prefabs/GameSideUIPanel");
    }
}
