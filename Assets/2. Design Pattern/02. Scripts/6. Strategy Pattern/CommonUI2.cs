using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public class CommonUI2 : MonoBehaviour
    {
        [SerializeField] private Button _leftBt, _rightBt;
        
        [SerializeField] private TextMeshProUGUI _leftBtText, _rightBtText;
        [SerializeField] private TextMeshProUGUI _contentText;

        public void Show(UIStrategy strategy)
        {
            ResetUI();
            strategy.Execute();
        }

        void ResetUI()
        {
            _leftBt.onClick.RemoveAllListeners();
            _rightBt.onClick.RemoveAllListeners();
            _leftBtText.color = new Color(50, 50, 50, 255);
            _rightBtText.color = new Color(50, 50, 50, 255);
            _rightBt.gameObject.SetActive(true);
        }
    }
}