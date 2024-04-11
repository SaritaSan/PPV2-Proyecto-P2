using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainScript : MonoBehaviour
{
    public static MainScript instance;
    public string SelectedLesson = "dummy";

    [Header("External GameObject Configuration")]
    //esta es nuestra imagen principal que contiene la UI 
    public GameObject creditos;


    private void Awake()
    {
        if(instance != null)
        {
            return;
        }
        else
        {
            instance = this;
        }
    }

    public void SetSelectedLesson(string lesson)
    {
        SelectedLesson = lesson;
        PlayerPrefs.SetString("SelectedLesson", SelectedLesson);
    }

    public void BeginGame()
    {
        SceneManager.LoadScene("Lesson");
    }



    public void EnableWindow()
    {
        //activeSelf es si está activado
        if (creditos.activeSelf)
        {
            //desactiva el objeto si está activo
            creditos.SetActive(false);
        }
        else
        {
            //activa el objeto si está desactivado
            creditos.SetActive(true);
            //MainScript.instance.SetSelectedLesson(LessonName);
        }
    }

    public void QuitAplication()
    {
        if (Input.GetMouseButtonDown(0)) // Verifica si se hace clic con el botón izquierdo del mouse
        {
            Application.Quit(); // Cierra la aplicación
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
