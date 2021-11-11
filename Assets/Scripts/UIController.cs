using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    public static UIController instance;

    public Text isSelectedSpanwer;
    public Button navigationButton;
    public string selectedARCharacter;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        goToARBtnVisibleHnadler(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToARBtnVisibleHnadler (bool isVisible)
    {
        navigationButton.gameObject.SetActive(isVisible);
    }

    public void donSomethingSpawner(string name)
    {
        isSelectedSpanwer.text = "SELECTED SPANWER NAME " + name;
        selectedARCharacter = name;
        goToARBtnVisibleHnadler(true);
    }

    public void GotoARPage()
    {
        SceneManager.LoadScene("ARSence");
        
    }

}
