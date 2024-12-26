using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableTwoAttach : XRGrabInteractable // using XR Grab Interactable
{
    public Transform leftAttatchTransform;
    public Transform rightAttatchTransform;


    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if(args.interactorObject.transform.tag == "Left Hand")
        {
            attachTransform = leftAttatchTransform;
        }
        else if (args.interactorObject.transform.tag == "Right Hand") 
        {
            attachTransform = rightAttatchTransform;
        }
        
        base.OnSelectEntered(args);
    }


}
