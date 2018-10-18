using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorway : MonoBehaviour {

    [SerializeField] Transform spawnPoint;

    public void teleport(GameObject player){
        player.transform.position = spawnPoint.position;
    }

}
