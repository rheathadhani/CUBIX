using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Help : MonoBehaviour
{
    public GameObject Panel;

	public void OpenPanel()
	{
	if(Panel !=null)
	{
			Panel.SetActive(true);
	}

	}
	
	}