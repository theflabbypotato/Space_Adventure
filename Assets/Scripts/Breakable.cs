using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Breakable : MonoBehaviour
{
    public List<GameObject> breakables;
    public float timeToBreak = 2;
    private float timer = 0;
    public UnityEvent OnBreak;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in breakables) {
            item.SetActive(false); // set all to not there
        }
        
    }

    public void Break() // broken the object
    {
        timer += Time.deltaTime; // adding the time in seconds

        if (timer > timeToBreak) { // if past 2 seconds
            foreach (var item in breakables) {
                item.SetActive(true);
                item.transform.parent = null; // set parent of all to null
            }

            OnBreak.Invoke();

            // set parent to not active
            gameObject.SetActive(false);
        }
    }

}
