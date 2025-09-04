using UnityEngine;

namespace Facade
{
    public class GameManager : Singleton<GameManager>
    {
        private SoundManager soundMgr;
        private DataManager dataMgr;
        private UIManager uiMgr;

        public void Initialize()
        {
            soundMgr = new GameObject("SoundManager").AddComponent<SoundManager>();
            dataMgr = new GameObject("SoundManager").AddComponent<DataManager>();
            uiMgr = new GameObject("SoundManager").AddComponent<UIManager>();
            
            soundMgr.transform.SetParent(transform);
            dataMgr.transform.SetParent(transform);
            uiMgr.transform.SetParent(transform);
        }

        public void StartGame()
        {
            dataMgr.LoadData();
            soundMgr.PlayBGM();
            uiMgr.InitSet();
        }
    }
}
