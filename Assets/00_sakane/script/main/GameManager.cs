using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	// Object to display results
	[SerializeField]
	GameObject resultObject;

	// Selected answer number
	List<int> answerNumbers = new List<int>();

	private void Awake()
	{
		// Hiding Objects Showing Results
		resultObject.SetActive(false);

		Debug.Log(AudioTypeManager.SoundType.CCode);
	}

	/// <summary>
	/// Decide the sound that will be the answer and play it
	/// </summary>
	public void SoundDecision()
	{
		
	}

	/// <summary>
	/// get answer
	/// </summary>
	/// <param name="number"></param>
	public void Answer(int number)
	{
		
	}

	/// <summary>
	/// Display success or failure when pressing the enter button
	/// </summary>
	public void Result()
	{
		
	}
}
