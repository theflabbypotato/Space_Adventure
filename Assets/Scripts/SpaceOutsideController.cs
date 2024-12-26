using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

public class SpaceOutsideController : MonoBehaviour
{
    public XRLever lever;
    public XRKnob knob;

    public float forwardSpeed;
    public float sideSpeed;

    private bool wasOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float forwardVelocity = forwardSpeed * (lever.value ? 1 : 0); // is the value on?  If so set to 1
        float sideVelocity = sideSpeed * (lever.value ? 1 : 0) * Mathf.Lerp(-1, 1, knob.value); // knob is 0 is -1, knob at 1 returns 1, otherwise near 0

        Vector3 velocity = new Vector3(sideVelocity, 0, forwardVelocity); // 3d vector for movement, only x and z
        transform.position += velocity * Time.deltaTime;

        if (lever.value != wasOn) { // change in the value, so doesnt play every frame
            if (lever.value) {
            AudioManager.instance.Play("Engine");
            }
            else {
                AudioManager.instance.Play("Engine");
            }

        }
        
        wasOn = lever.value;

    }
}
