using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterObject : MonoBehaviour {

    [SerializeField] GameObject partnerObject;

    public void toggleActivation(){
        gameObject.SetActive(false);
        partnerObject.SetActive(true);
    }

}
