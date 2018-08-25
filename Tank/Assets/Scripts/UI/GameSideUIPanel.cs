using UnityEngine;

public class GameSideUIPanel:UIBase
{
    public override void Start()
    {
        base.Start();
        CreateChildPanel<GamePanel>("Tr_game", "Prefabs/GamePanel");
    }

}
