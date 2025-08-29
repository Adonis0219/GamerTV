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
            // ��ư ���ڻ� �⺻ ������ ����
            _rightBt.gameObject.SetActive(true);
            _leftBt.gameObject.SetActive(true);
        }

        void SaveListeners()
        {
            // ���̺� UI�� �� �������� ����
            // ���� ����
            // ��ư ����~
            
            _leftBt.onClick.AddListener(() =>
            {
                Debug.Log("���� ��ư ����");
                gameObject.SetActive(false);
            });
         
            _rightBt.onClick.AddListener(() =>
            {
                Debug.Log("��� ��ư ����");
                gameObject.SetActive(false);
            });
        }

        void QuitListeners() { /*���� UI�� �� �������� ����*/ }
        void RewardListeners() { /*���� UI�� �� �������� ����*/ }
    }
}