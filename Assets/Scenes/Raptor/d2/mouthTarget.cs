using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class mouthTarget : EventTrigger
{
    //used to check if the magnifying glass has been over the mouth 
    public static bool mouth = false;

    public override void OnPointerEnter(PointerEventData eventData)
    {
        //if the user is dragging the magnifying glass
        if(magDrag.itemBeingDragged != null)
        {
            mouth = true;

        }
       
    }
   


}
