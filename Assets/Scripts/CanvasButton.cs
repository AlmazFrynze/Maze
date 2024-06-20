using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CanvasButton : MonoBehaviour
{
  public GameObject gameController;
  public void RestartGame()
  {
    gameController.GetComponent<BuildMaze>().RerunMaze();


  }
}
