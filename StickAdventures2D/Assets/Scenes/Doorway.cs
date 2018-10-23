using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorway : MonoBehaviour {

    [SerializeField] Transform spawnPoint;
    [SerializeField] string puzzleCode;
    [SerializeField] GameObject[] currentRoomObjects; //the connecting rooms objects

    public void teleport(GameObject player){
        player.transform.position = spawnPoint.position;
    }

    public GameObject[] getObjects(){
        return currentRoomObjects;
    }

    public string getCode(){
        return puzzleCode;
    }
}
