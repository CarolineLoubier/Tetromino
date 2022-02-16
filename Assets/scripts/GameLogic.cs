using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
	public GameObject[] tetromino = new GameObject[7];
	public char[] pField;
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

	public int Rotate(int px, int py, int r)
	{
		switch (r % 4)
		{
			case 0: return py * 4 + px;
			case 1: return 12 + py - (px * 4);
			case 2: return 15 - (py * 4) - px;
			case 3: return 3 - py + (px * 4);
		}
		return 0;
	}

	public bool DoesPieceFit(int nTetromino, int nRotation, int nPosX, int nPosY)
	{

		for (int px = 0; px < 4; px++)
			for (int py = 0; py < 4; py++)
			{
				//Get Index Into piece
				int pi = Rotate(px, py, nRotation);
				//Get Index into field
				int fi = (nPosY + py) * nFieldWidth + (nPosX + px);

				if (nPosX + px >= 0 && nPosX + px < nFieldWidth)
				{
					if (nPosY + py >= 0 && nPosY + py < nFieldHeight)
					{
						if (pField[fi] != 0)
						return false;//fail on first hit
					}
				}
			}

	return true;
	}

	// Start is called before the first frame update
	void Start()
    {
		nCurrentX = nFieldWidth / 2;
		nCurrentY = 0;

		while(!bGameOver)
        {
			nSpeedCounter++;
			bForceDown = (nSpeedCounter == nSpeed);

				bKey[0] = (Input.GetKey("left"));
				bKey[1] = (Input.GetKey("down"));
				bKey[2] = (Input.GetKey("right"));
				bKey[3] = (Input.GetKey("z"));

		}
	}
	



}
