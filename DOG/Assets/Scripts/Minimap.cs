using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    Player_Hero player;
    public System.Action OnDisable;

    private void Awake() {
    }

    private void Start()
    {
        player = GameManager.Inst.MainPlayer;
    } 
    
    private void LateUpdate()
    {
        Vector3 playerPos = player.transform.position;
        playerPos.z = -10f;
        transform.position = playerPos;
    }
}
