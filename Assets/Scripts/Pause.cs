﻿using UnityEngine;

public class Pause : MonoBehaviour {


    public GameObject Canvas;
    public GameObject Camera;

    bool Paused = false;

    void Start(){
        Canvas.gameObject.SetActive (false);
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if(Paused == true){
                Time.timeScale = 1.0f;
                Canvas.gameObject.SetActive (false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
//                Camera.GetComponent<AudioSource>().Play ();
                Paused = false;
            } else {
                Time.timeScale = 0.0f;
                Canvas.gameObject.SetActive (true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
//                Camera.GetComponent<AudioSource>().Pause ();
                Paused = true;
            }
        }
    }
    public void Resume(){
        Time.timeScale = 1.0f;
        Canvas.gameObject.SetActive (false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
//        Camera.GetComponent<AudioSource>().Play ();
    }

    void restartGame(){
        Debug.Log("Here");
    }
}    