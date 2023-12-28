using UnityEngine;
using UnityEngine.SceneManagement;

public class Starting : MonoBehaviour
{
public void Begin ()
{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
  }
