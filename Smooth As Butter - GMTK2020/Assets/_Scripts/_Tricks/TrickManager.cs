using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrickManager : MonoBehaviour
{
    #region Singleton
    public static TrickManager _instance;

    private void Awake()
    {
        if (_instance == null)
            _instance = this;
        else if (_instance != null)
            Destroy(this);
    }
    #endregion

    [SerializeField] private TextMeshProUGUI trickText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TrickModifierTracker modifers;

    private Coroutine endRoutine;

    private List<string> strings = new List<string>();
    private List<int> counts = new List<int>();
    private float curScore = 0;

    // THE SCORE
    [HideInInspector] public float score = 0;

    [Space]
    [SerializeField] private float trickEndDelay = 4;

    [Header("Sound")]
    [SerializeField] private AudioClip[] clips = new AudioClip[0];
    [SerializeField] private AudioSource[] sources = new AudioSource[0];
    private int souceIndex = 0;

    private void Start()
    {
        trickText.text = "";
        if (scoreText != null)
            scoreText.text = "";
    }

    public void AddTrick(string pName, int pScore)
    {
        string curString = "";

        // Update Text
        TrickModifierTracker.Modifer modifer = modifers.side();
        curString += " " + modifer.name;
        curScore += modifer.score;

        modifer = modifers.spins();
        if (modifer.score > 0)
        {
            curString += " " + modifer.name;
            curScore += modifer.score;
        }

        curString += " " + pName;
        curScore += pScore;

        // Check for repeat
        for (int i = 0; i < strings.Count; i++)
        {
            if (strings[i] == curString)
            {
                counts[i]++;
                curString = "";
                break;
            }
        }

        // No repeat
        if (curString != "")
        {
            strings.Add(curString);
            curString = "";
            counts.Add(1);
        }

        // Add together entire string
        for (int i = 0; i < strings.Count; i++)
        {
            if (i != 0)
                curString += "\nto";

            curString += strings[i] + (counts[i] > 1 ? " x" + counts[i] : "");
        }

        // Result
        string scoreString = curScore.ToString("n0");

        trickText.text = curString + "\n+ " + scoreString;

        // Laughing
        if (sources[souceIndex].isPlaying == false)
        {
            sources[souceIndex].clip = clips[Mathf.RoundToInt(Random.value * (clips.Length - 1))];
            sources[souceIndex].Play();
        }
        souceIndex++;
        if (souceIndex == sources.Length)
            souceIndex = 0;

        // Reset end delay
        if (endRoutine != null)
            StopCoroutine(endRoutine);
        endRoutine = StartCoroutine(TrickEndDelay());
    }

    private IEnumerator TrickEndDelay()
    {
        yield return new WaitForSeconds(trickEndDelay);

        strings.Clear();
        counts.Clear();
        trickText.text = "";

        score += curScore;
        curScore = 0;
        if (scoreText != null)
            scoreText.text = "Score: " + score.ToString();

    }
}
