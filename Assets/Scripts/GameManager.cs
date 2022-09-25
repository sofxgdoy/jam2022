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
          yield return new WaitForSeconds(1.0f);
    
           SceneManager.LoadScene(sceneName);
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
