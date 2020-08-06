using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public enum GameState { AttractMode, GameIntro, RoundSetup, Playing, RoundOver, Results, Paused }
	public static GameState currentGameState = GameState.Playing;
}
