using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



//FUNCIONES LÓGICA DE LOS BOTONES 
public class LogicaBotones : MonoBehaviour
{

    public void RealidadAumentada(){
        SceneManager.LoadScene("ARCore_Geospatial_Upiicsa");

    }

    public void RealidadVirtual(){
        SceneManager.LoadScene("Demo_Convai_Upiicsa - Mobile");

    }

    public void Creditos(){
        SceneManager.LoadScene("Creditos");
    }

    public void Salida(){
        Application.Quit();
    }

    public void Atras(){
        SceneManager.LoadScene("Menu");

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
