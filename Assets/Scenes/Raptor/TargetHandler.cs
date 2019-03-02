using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TargetHandler : MonoBehaviour, IDropHandler
{
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
            draggable.itemBeingDragged.transform.SetParent(transform);
            //if object in target slot, change to true 
            draggable.slot = true;
        }
    }

}