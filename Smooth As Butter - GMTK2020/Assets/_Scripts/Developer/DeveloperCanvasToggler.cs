using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeveloperCanvasToggler : MonoBehaviour
{
	private Canvas m_Canvas;

	private void Awake()
	{
		m_Canvas = GetComponent<Canvas>();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.BackQuote))
		{
			m_Canvas.enabled = !m_Canvas.enabled;
		}
	}
}