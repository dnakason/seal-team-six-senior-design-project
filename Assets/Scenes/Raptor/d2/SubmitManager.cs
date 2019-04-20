using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubmitManager : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject clipboard;

    //plays the hide clipboard animation and changes the scene 
    IEnumerator hide_clipboard()
    {
        clipboard.GetComponent<Animator>().Play("hide_clipboard");
        yield return new WaitForSeconds(3);
    }

    //used to determine if takes user to next process or the same one
    public void notice(){
        int index = dropdown.GetComponent<Dropdown>().value;

        if(index == 1)
        {
            StartCoroutine(hide_clipboard());
        }
        else
        {
            SceneManager.LoadScene("RaptorDiagnose2");
        }
        
    }


}
