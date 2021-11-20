using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Titleback : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("title");
    }
}
