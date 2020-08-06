using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSequenceSceneChanger : MonoBehaviour
{
    public void EndIntro()
	{
		SceneManager.LoadSceneAsync(1);
	}
}
