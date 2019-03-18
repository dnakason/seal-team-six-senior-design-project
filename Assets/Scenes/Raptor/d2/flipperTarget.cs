using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class flipperTarget : EventTrigger
{
    //used to check if magnifying glass has been over flipper
    public static bool flipper = false;


    public override void OnPointerEnter(PointerEventData eventData)
    {
        //if the user is dragging the magnifying glass
        if (magDrag.itemBeingDragged != null)
        {
            flipper = true;

        }

    }
}
