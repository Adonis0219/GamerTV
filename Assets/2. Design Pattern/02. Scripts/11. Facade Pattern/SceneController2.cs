using System;
using UnityEngine;
using UnityEngine.UI;

namespace Facade
{
    public class SceneController2 : MonoBehaviour
    {
        private SoundManager soundMgr;
        private DataManager dataMgr;
        private UIManager uiMgr;

        public Button startBt;

        private void Start()
        {
            soundMgr = new GameObject("SoundManager").AddComponent<SoundManager>();
            dataMgr = new GameObject("SoundManager").AddComponent<DataManager>();
            uiMgr = new GameObject("SoundManager").AddComponent<UIManager>();
            
            soundMgr.transform.SetParent(transform);
            dataMgr.transform.SetParent(transform);
            uiMgr.transform.SetParent(transform);
            
            startBt.onClick.AddListener(() =>
            {
                dataMgr.LoadData();
                soundMgr.PlayBGM();
                uiMgr.InitSet();
            });
        }
    }
}