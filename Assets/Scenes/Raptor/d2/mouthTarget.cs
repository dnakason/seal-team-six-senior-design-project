using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


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
            GetComponent<Animator>().enabled = false;
            //changes the transparency of the target to 0; its defualt state 
            Image img = GetComponent<Image>();
            Color c = img.color;
            c.a = 0;
            img.color = c;
        }
       
    }
   


}
