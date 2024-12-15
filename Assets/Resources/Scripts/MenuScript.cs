using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void BotonStart()
    {
        SceneManager.LoadScene("HelloCardboard", LoadSceneMode.Single);
    }

    // Update is called once per frame
    public void BotonSalir()
    {
        Debug.Log("Salimos de la app");
        Application.Quit();
    }
    public void Atras(){
        SceneManager.LoadScene("Menu");

    } 
}
