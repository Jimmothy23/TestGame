//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayModeText : MonoBehaviour
{
    private TextMeshProUGUI myTMP_UI;

    private void Start()
    {
        myTMP_UI = GetComponent<TextMeshProUGUI>();
        myTMP_UI.text = "Whee!" + "\n" + "I'm bouncing!";
    }
}
