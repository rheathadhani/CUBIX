using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
  [SerializeField] private GameObject pauseMenuUI;
  [SerializeField] private bool isPaused;
  
 

  
  private void Update()   
  {
  	  if (Input.GetKeyDown(KeyCode.Escape))
	  {
	  	  isPaused = !isPaused;

	  }
	  if (isPaused)
	  {
	  	  ActivateMenu();
	  }
 else
 {
 	 DeactivateMenu();
 }
}
  void ActivateMenu()
  {
  	   pauseMenuUI.SetActive(true);
	   Time.timeScale = 0f;
	   isPaused = true;
  }
  
 public void DeactivateMenu()
  {
	pauseMenuUI.SetActive(false);
   Time.timeScale = 1f;
	   isPaused = false;
  }

  public void LoadMenu (){
  	  SceneManager.LoadScene("Opening");
  }
  
	
	

	

	
 
 
 }
