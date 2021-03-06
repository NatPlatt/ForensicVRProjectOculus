﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AltSocketScaler : XRSocketInteractor
{
    public float scaleNew = .2f;
    //public bool canScale { get; set; } = true;
    //public bool canInteract = true;

    private Collider objectToScale;
    private Vector3 startScale;
    private Vector3 newScale;


    protected override void Awake()
    {
        base.Awake();
        startScale = new Vector3(0, 0, 0);
    }
   
   
    protected override void OnSelectEnter(XRBaseInteractable interactable)
    {
        base.OnSelectEnter(interactable);
        objectToScale = interactable.GetComponentInChildren<Collider>();
        if (startScale == Vector3.zero)
        {
            startScale = interactable.transform.localScale;
            ScaleObject();
        }
    }

    
    protected override void OnSelectExit(XRBaseInteractable interactable)
    {
        base.OnSelectExit(interactable);
        if (startScale != Vector3.zero)
        {
            ReturnScale();
        }
    }

    public void ScaleObject()
    {
        if (objectToScale != null)
        {
            newScale = startScale * scaleNew;
            objectToScale.transform.localScale = newScale;

        }

    }


    public void ReturnScale()
    {
        if (objectToScale != null)
        {
            objectToScale.transform.localScale = startScale;
            startScale = new Vector3(0, 0, 0);
        }

    }
}
