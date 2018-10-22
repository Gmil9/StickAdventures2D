using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = ("Interactable Object"))]
public class InterObject : ScriptableObject {

    public bool isActivated = false;
    [SerializeField] GameObject inActiveGO;
    [SerializeField] GameObject ActiveGO;

    public void toggleSprite(){
        isActivated = !isActivated;
    }

}
