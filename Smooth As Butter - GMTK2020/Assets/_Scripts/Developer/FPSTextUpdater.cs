using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// https://wiki.unity3d.com/index.php/FramesPerSecond
public class FPSTextUpdater : MonoBehaviour
{
	public float updateInterval = 0.05f;
	public bool colorized = false;

	private TMP_Text m_TMP_Text;
	private float accumulatedFPS = 0f;
	private int accumulatedFrames = 0;
	private float timeLeftInInterval;

	private void Awake()
	{
		m_TMP_Text = GetComponent<TMP_Text>();
	}

	void Update()
    {
		timeLeftInInterval -= Time.deltaTime;
		accumulatedFPS += Time.timeScale / Time.deltaTime;
		++accumulatedFrames;

		if (timeLeftInInterval <= 0f)
		{
			float fps = accumulatedFPS / accumulatedFrames;

			if (colorized)
			{
				if (fps < 30)
				{
					m_TMP_Text.color = Color.red;
				}
				else if (fps < 60)
				{
					m_TMP_Text.color = Color.yellow;
				}
				else
				{
					m_TMP_Text.color = Color.green;
				}
			}

			m_TMP_Text.text = fps.ToString("0 FPS");

			timeLeftInInterval = updateInterval;
			accumulatedFPS = 0f;
			accumulatedFrames = 0;
		}
    }
}
