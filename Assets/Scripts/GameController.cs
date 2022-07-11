using UnityEngine;

public class GameController : MonoBehaviour
{
  [SerializeField] private ObjectSpawner _objectSpawner;
  [SerializeField] private UIManager _uiManager;

  private void Start()
  {
    _uiManager.OnPushStart += CreateLevelOne;
    _uiManager.ShowStartMenuButtons();
  }

  private void CreateLevelOne()
  {
    _objectSpawner.SpawnBall();
    _objectSpawner.SpawnPlatform();
  }
}
