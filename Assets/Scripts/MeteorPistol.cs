using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class MeteorPistol : MonoBehaviour
{
    public ParticleSystem particles;

    public LayerMask layerMask;
    public Transform shootSource; // starting point of bullet
    public float distance = 10;

    private bool rayActive = false;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartShoot()); // listening when grabbed
        grabInteractable.deactivated.AddListener(x => StopShoot());
    }

    public void StartShoot()
    {
        AudioManager.instance.Play("Pistol");
        particles.Play();
        rayActive = true;
    }

    public void StopShoot()
    {
        AudioManager.instance.Stop("Pistol");
        particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear); // stops the particle, all dissapear
        rayActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (rayActive) 
        {
            RaycastCheck();
        }
    }

    // raycast
    void RaycastCheck()
    {
        RaycastHit hit; // if hit
        bool hasHit = Physics.Raycast(shootSource.position, shootSource.forward,
            out hit, distance, layerMask); // function

        if (hasHit)
        {
            hit.transform.gameObject.SendMessage("Break", SendMessageOptions.DontRequireReceiver); // sends a message
            // server message doesnt need receiver
        }
    }
}
