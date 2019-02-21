using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Raptor_Level : MonoBehaviour
{
   public void LoadRaptorScene()
    {
        SceneManager.LoadScene("RaptorDiagnose");
    }
}
