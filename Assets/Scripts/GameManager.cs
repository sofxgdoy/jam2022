using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager GameManagerInstance;
    

    /*void Awake() {
        instance = GetComponent<GameManager>();
    }*/

    
    void Start()
    {
        GameManagerInstance = this;
    }

    public void CambioDeEscena(string sceneName){
        //SceneManager.LoadScene(sceneName);//
        StartCoroutine(CambioEscenaDelay());
        
       IEnumerator CambioEscenaDelay() {
          yield return new WaitForSeconds(0.5f);
    
           SceneManager.LoadScene(sceneName);
        }
    }

    public void CambioMuerte(string sceneName) {

        if (ControlPuerta.nivel1 == false) {
            SceneManager.LoadScene("Nivel1");
        }
        if (ControlPuerta.nivel1== true && ControlPuerta.nivel2 == false) {
            SceneManager.LoadScene("Nivel2");
        }

        if(ControlPuerta.nivel1 && ControlPuerta.nivel2) {
            SceneManager.LoadScene("Nivel3");
        }
    }

    public void ReloadScene() {
		CambioDeEscena(SceneManager.GetActiveScene().name);
	}

    public void ExitGame() {
        Application.Quit();
        Debug.Log("Quit");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
