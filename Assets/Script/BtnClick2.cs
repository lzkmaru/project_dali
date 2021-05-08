using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnClick2 : MonoBehaviour
{
    public void BtnNewScene()
    {
        SceneManager.LoadScene("2_course");
    }
}