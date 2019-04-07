﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class xray_target : MonoBehaviour, IDropHandler
{
    //references the instructions panel 
    public GameObject Instructions;
    public GameObject XRay;
    public GameObject Raptor;

    public GameObject item

    {
        get
        {
            //If target has a child
            if (transform.childCount > 0)
            {
                //returns first child
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        //if we dont have an item in the target, accept new item
        if (!item)
        {
            //gets the item being dragged, sets parent to the current transform
            xray_drag.itemBeingDragged.transform.SetParent(transform);
            //if object in target slot, change to true 
            xray_drag.slot = true;
            //hides the instructions panel
            Instructions.gameObject.SetActive(false);

            //brings x-ray onto seal sprite 
            XRay.GetComponent<Animator>().SetBool("x_ray", true);
            //changes raptor animation once the x-ray is ontop
            Raptor.GetComponent<Animator>().SetBool("raptor_xray",true);
        }
    }




}