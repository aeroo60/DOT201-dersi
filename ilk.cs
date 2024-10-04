using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilk : MonoBehaviour
{
    // Start is called before the first frame update
    private string startText = "head started";
    private string updateText = "head started";
    private int updateCount; 
    void Start()
    {
        Debug.Log(startText);
    }

    // Update is called once per frame
    void Update()
    {

        updateCount++;
        Debug.Log(updateText);
        Debug.Log(message: "update count" + updateCount);
    }
}
