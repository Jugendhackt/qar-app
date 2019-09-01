using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextChancher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChancheText(string text)
    {
        gameObject.GetComponent<TextMeshPro>().text = text;
    }

    public void ChanchePText(string text)
    {
        gameObject.GetComponent<Text>().text = text;
    }
}
