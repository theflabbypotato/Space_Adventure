using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.XR.Content.Interaction;

public class PlaySteps : MonoBehaviour
{
    PlayableDirector director;
    public List<Step> steps;

    // Start is called before the first frame update
    void Start()
    {
        director = GetComponent<PlayableDirector>();
    }

    [System.Serializable]
    // class, there is a list of steps
    public class Step {
        public string name;
        public float time;
        public bool hasPlayed = false;
    }

    public void PlayStepIndex(int index) {
        Step step = steps[index];

        if (!step.hasPlayed) {
            step.hasPlayed = true; // sets to true

            director.Stop();
            director.time = step.time; // set to the time of the step
            director.Play(); // play after

        }
    }
}
