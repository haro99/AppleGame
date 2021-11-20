using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSignal : MonoBehaviour
{

    public Text text;
    // Start is called before the first frame update
    public void TextChange()
    {
        text.text = "GO!";
    }
}
