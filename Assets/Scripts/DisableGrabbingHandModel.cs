using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableGrabbingHandModel : MonoBehaviour
{
    public GameObject leftHandModel;
    public GameObject rightHandModel;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideGrabbingHand); // fire function when this object is grabbed
        grabInteractable.selectExited.AddListener(ShowGrabbingHand);
    }

    public void HideGrabbingHand(SelectEnterEventArgs args) // enter
    {
        // removes the hand on enter (grabbing)
        if (args.interactorObject.transform.tag == "Left Hand") {
            leftHandModel.SetActive(false);
        } else if (args.interactorObject.transform.tag == "Right Hand") {
            rightHandModel.SetActive(false);
        }
    }

    public void ShowGrabbingHand(SelectExitEventArgs args) // exit
    {
        // shows the hand on exit
        if (args.interactorObject.transform.tag == "Left Hand") {
            leftHandModel.SetActive(true);
        } else if (args.interactorObject.transform.tag == "Right Hand") {
            rightHandModel.SetActive(true);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
