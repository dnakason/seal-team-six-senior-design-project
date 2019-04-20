using UnityEngine;
using UnityEngine.EventSystems;


public class magDrag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    //game object that is being dragged
    public static GameObject itemBeingDragged;
    //stores the start position of the game object
    Vector3 startPosition;
    //stores the parent of the game object
    Transform startParent;
    //references clipboard game object
    public GameObject clip_board;

    public GameObject mouth_target;
    public GameObject flipper_target;

    //references instructions game object
    public GameObject Instructions;

    //plays clip board animation
    public void play_clipboard()
    {
        Animator anim = clip_board.GetComponent<Animator>();
        anim.SetBool("play", true);

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //sets item being dragged to the current game object
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        //sets the start parent of the object
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        transform.SetParent(transform.root);
       

    }

    public void OnDrag(PointerEventData eventData)
    {
        //position of game object follows mouse position 
        transform.position = eventData.position;

        //if user hasn't hovered over flipper, play flipper target help
        if (flipperTarget.flipper == false) {
            flipper_target.GetComponent<Animator>().SetBool("targetHelp", true);
        }

        //if user has hovered over flipper but not the mouth, play mouth target help
        else if (flipperTarget.flipper == true && mouthTarget.mouth == false)
        {
            mouth_target.GetComponent<Animator>().SetBool("targetHelp", true);
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;

        //snaps object back to original slot if not over the target slot 
        if (transform.parent == startParent || transform.parent == transform.root)
        {
            transform.position = startPosition;
            transform.SetParent(startParent);
        }

        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void Update()
    {
        //if magnifying glass hovered over both mouth and flipper, play clipboard animation
        if(mouthTarget.mouth && flipperTarget.flipper)
        {
            //hides the instructions panel
            Instructions.gameObject.SetActive(false);
            play_clipboard();
        }
    }
    void Start()
    {
        flipperTarget.flipper = false;
        mouthTarget.mouth = false;
    }
}
