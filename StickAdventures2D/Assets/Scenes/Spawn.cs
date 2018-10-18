using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    [SerializeField] GameObject player;
    [SerializeField] Transform spawnPoint;

	void Start () {
        player.transform.position = spawnPoint.position;
	}

}
