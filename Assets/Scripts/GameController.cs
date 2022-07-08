using UnityEngine;

public class GameController : MonoBehaviour
{
  [SerializeField] private ButtonController _buttonController;
  [SerializeField] private ObjectSpawner _objectSpawner;

  private void Start()
  {
    _buttonController.OnPushStart += CreateLevelOne;
  }

  private void CreateLevelOne()
  {
    _objectSpawner.SpawnBall();
    _objectSpawner.SpawnPlatform();
  }
}
