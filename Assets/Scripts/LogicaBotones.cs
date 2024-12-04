using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



//FUNCIONES LÓGICA DE LOS BOTONES 
public class LogicaBotones : MonoBehaviour
{

    public void RealidadAumentada(){
        SceneManager.LoadScene("");

    }

    public void RealidadVirtual(){
        SceneManager.LoadScene("");

    }

    public void Creditos(){
        SceneManager.LoadScene("Creditos");
    }

    public void Salida(){
        //application.quit();
    }

    public void Atras(){
        SceneManager.LoadScene("MenuPrincipal");

    } 
}

//ENFOCADO A LA MUSCIA 
    public class Music:MonoBehaviour{
        [SerializeField] AudioSource music;
        
        public void OnMusic(){
            //music.play();
        }

        public void OffMusic(){
            //music.stop();
        }
    }
