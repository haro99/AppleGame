using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    public GameObject result;

    // Start is called before the first frame update
    void Start()
    {
        result.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void REseton()
    {
        result.SetActive(true);
    }
}
