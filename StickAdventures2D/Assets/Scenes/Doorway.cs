using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorway : MonoBehaviour {

    [SerializeField] Transform spawnPoint;
    [SerializeField] string puzzleCode;
    [SerializeField] InterObject[] currentObjects;

    public void teleport(GameObject player){
        player.transform.position = spawnPoint.position;
    }

    public InterObject[] getObjects(){
        return currentObjects;
    }

    public void setObjects(InterObject[] objects){
        currentObjects = objects;
    }

    public string getCode(){
        return puzzleCode;
    }
}
