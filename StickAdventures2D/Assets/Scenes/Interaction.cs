using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    [SerializeField] GameObject[] currentRoomObjects;
    [SerializeField] GameObject currentObject;
    Doorway d;
    InterObject inter;
    [SerializeField] string puzzleCode;
    [SerializeField] string currentCode = "";
    int stars;

    int interCode = 0;

    private void Update()
    {
        if(interCode == 1 && Input.GetKeyDown(KeyCode.F)){
            d.teleport(gameObject);
            currentRoomObjects = d.getObjects();
            puzzleCode = d.getCode();
            currentCode = "";
        }
        else if(interCode == 2 && Input.GetKeyDown(KeyCode.F)){
            inter.toggleActivation();
            checkInteractions();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("door")){
            interCode = 1;
            d = collision.GetComponent<Doorway>();
        }
        if(collision.CompareTag("interactable")){
            currentObject = collision.gameObject;
            interCode = 2;
            inter = collision.GetComponent<InterObject>();
        }
        if(collision.CompareTag("star")){
            stars++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        currentObject = null;
        interCode = 0;
    }

    void checkInteractions(){
        currentCode = "";
        int t = 0;
        foreach(GameObject i in currentRoomObjects){
            if(i.activeSelf == true){
                currentCode = currentCode.Insert(t, "1");
            }else{
                currentCode = currentCode.Insert(t, "0");
            }
            t++;
        }
        //if tempcode == puzzleCode
            //spawnStar()
    }

}
