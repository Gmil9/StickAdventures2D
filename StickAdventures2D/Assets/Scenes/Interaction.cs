using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "door" && Input.GetKeyDown(KeyCode.F))
        {
            Doorway d = collision.GetComponent<Doorway>();
            d.teleport(gameObject);
        }
    }
}
