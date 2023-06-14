using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  static readonly int BoardSize = 3;
  private int[,] board = new int[BoardSize, BoardSize];

  private int currentPlayer = 1;

  public void SwitchPlayer()
  {
    currentPlayer = 3 - currentPlayer; // Switches between 1 and 2
  }

  // Start is called before the first frame update
  void Start()
  {
    InitializeBoard();
  }

  // Initialize the board
  private void InitializeBoard()
  {
    for (int i = 0; i < BoardSize; i++)
    {
      for (int j = 0; j < BoardSize; j++)
      {
        board[i, j] = 0;
      }
    }
  }

  // Saves a player (1 or 2) to the board | 1 represents "X's" and 2 represents "O's"
  public bool MakeMove(int x, int y, int player)
  {
    if (board[x, y] == 0)
    {
      board[x, y] = player;
      return true;
    }
    return false;
  }

  // Checks for a win.
  public bool CheckWin()
  {
    // check rows and columns
    for (int i = 0; i < BoardSize; i++)
    {
      if (board[i, 0] != 0 && board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2])
        return true;
      if (board[0, i] != 0 && board[0, i] == board[1, i] && board[0, i] == board[2, i])
        return true;
    }
    // check diagonals
    if (board[0, 0] != 0 && board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
      return true;
    if (board[0, 2] != 0 && board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
      return true;
    return false;
  }

  // Checks if any cell is 0 (no move)
  public bool CheckDraw()
  {
    for (int i = 0; i < BoardSize; i++)
    {
      for (int j = 0; j < BoardSize; j++)
      {
        if (board[i, j] == 0)
          return false;
      }
    }
    return true;
  }


  // Update is called once per frame
  void Update()
  {

  }
}
