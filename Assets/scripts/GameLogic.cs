using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
	private int nFieldWidth = 12;
	private int nFieldHeight = 18;

	private bool bGameOver = false;

	private int nCurrentPiece = 0;
	private int nCurrentRotation = 0;
	private int nCurrentX;
	private int nCurrentY;

	private bool[] bKey = new bool[4];
	private bool bRotateHold = false;

	private int nSpeed = 20;
	private int nSpeedCounter = 0;
	private bool bForceDown = false;
	private int nPieceCount = 0;
	private int nScore = 0;

	// Start is called before the first frame update
	void Start()
    {
		nCurrentX = nFieldWidth / 2;
		nCurrentY = 0;
	}
	



}
