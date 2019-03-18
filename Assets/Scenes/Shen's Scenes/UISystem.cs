using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UISystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Load scene with the scene number from build
    // main menu(0) seal1 (1)
    public void LoadScene(int num)
    {
        SceneManager.LoadScene(num);

    }
}
