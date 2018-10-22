using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    //currentObjects[]
    //Doorway d;
    //String puzzleCode;
    //int Stars;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if door
            //setObjects
            //teleport
            //getObjects
            //getCode
        //if interactable   
            //toggleActive
            //checkInteractions()
        //if inventory object(stars)
            //add to counter
    }

    void checkInteractions(){
        //String tempcode = ""
        //for each(o in currentObjects)
            //if o.isActive, tempcode add "1"
            //if o.isNotActive, tempcode add "0"
        //if tempcode == puzzleCode
            //spawnStar()
    }

}
