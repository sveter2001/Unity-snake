using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private EndWindow myEndWindow;

    private void OnCollisionEnter2D(Collision2D collision){
        Debug.Log(collision.gameObject.name);        
        Debug.Log(this.name);
        Debug.Log(collision.GetContact(0).point);
        OpenWindow("gg wp");
    }

    private void OpenWindow(string message){
        myEndWindow.gameObject.SetActive(true);
        myEndWindow.RestartBt.onClick.AddListener(RestartClicked);
        myEndWindow.ExitBt.onClick.AddListener(ExitClicked);
        myEndWindow.messageText.text = message;
    }

    private void RestartClicked(){
        myEndWindow.gameObject.SetActive(false);
        Debug.Log("Restart");
    }

    private void ExitClicked(){
        myEndWindow.gameObject.SetActive(false);
        Debug.Log("Exit");
    }
}
