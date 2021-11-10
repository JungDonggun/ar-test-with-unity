using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public Text isSelectedSpanwer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void donSomethingSpawner(string name)
    {
        Debug.Log("IS CLICKED" + name);
        isSelectedSpanwer.text = "IS SELECTED SPANWER IS " + name;
    }

}
