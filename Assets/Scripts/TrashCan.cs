using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private void Start() {
        // at the start sets this to listen
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InsideTrash); 
    }   
    

    public void InsideTrash(GameObject go) {
        go.SetActive(false); // gets rid
    }
}
