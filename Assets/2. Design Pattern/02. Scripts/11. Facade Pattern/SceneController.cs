using System;
using UnityEngine;
using UnityEngine.UI;

namespace Facade
{
    public class SceneController : MonoBehaviour
    {
        public Button startBt;

        private void Start()
        {
            GameManager.Instance.Initialize();
            
            startBt.onClick.AddListener((GameManager.Instance.StartGame));
        }
    }
}