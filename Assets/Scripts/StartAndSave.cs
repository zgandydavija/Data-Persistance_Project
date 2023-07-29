using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class StartAndSave : MonoBehaviour
{
    //  Variables
    public GameObject playerName;
    public string playerNameString;
    public int bestScore;
    public string bestPlayer;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        GameObject.Find("StartAndSave").GetComponent<SaveManager>().LoadData();
        playerNameString = playerName.GetComponent<TMP_Text>().text;
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
