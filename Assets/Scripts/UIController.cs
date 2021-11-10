using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    public Text isSelectedSpanwer;
    public Button navigationButton;
    
    // Start is called before the first frame update
    void Start()
    {
        goToARBtnVisibleHnadler();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToARBtnVisibleHnadler ()
    {
        navigationButton.gameObject.SetActive(true);
    }

    public void donSomethingSpawner(string name)
    {
        isSelectedSpanwer.text = "SELECTED SPANWER NAME " + name;
        goToARBtnVisibleHnadler();
    }

    public void GotoARPage()
    {
        SceneManager.LoadScene("ARSence");
        
    }

}
