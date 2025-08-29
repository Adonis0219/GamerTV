using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public enum UI_TYPE { Save, Quit, Reward}
    
    public class CommonUI : MonoBehaviour
    {
        [SerializeField] private Button _leftBt, _rightBt;
        
        [SerializeField] private TextMeshProUGUI _leftBtText, _rightBtText;
        [SerializeField] private TextMeshProUGUI _contentText;

        [SerializeField] private Sprite _saveLeftSpr, _saveRightSpr;
        // ...

        public void Show(UI_TYPE type)
        {
            SetUIType(type);
            gameObject.SetActive(true);
        }

        void SetUIType(UI_TYPE type)
        {
            ResetUI();

            switch (type)
            {
                case UI_TYPE.Save:
                    SaveListeners();
                    break;
                case UI_TYPE.Quit:
                    break;
                    QuitListeners();
                case UI_TYPE.Reward:
                    RewardListeners();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        void ResetUI()
        {
            _leftBt.onClick.RemoveAllListeners();
            _rightBt.onClick.RemoveAllListeners();
            // 버튼 글자색 기본 색으로 변경
            _rightBt.gameObject.SetActive(true);
            _leftBt.gameObject.SetActive(true);
        }

        void SaveListeners()
        {
            // 세이브 UI일 때 수정해줄 내용
            // 글자 수정
            // 버튼 연결~
            
            _leftBt.onClick.AddListener(() =>
            {
                Debug.Log("저장 버튼 동작");
                gameObject.SetActive(false);
            });
         
            _rightBt.onClick.AddListener(() =>
            {
                Debug.Log("취소 버튼 동작");
                gameObject.SetActive(false);
            });
        }

        void QuitListeners() { /*종료 UI일 때 수정해줄 내용*/ }
        void RewardListeners() { /*보상 UI일 때 수정해줄 내용*/ }
    }
}