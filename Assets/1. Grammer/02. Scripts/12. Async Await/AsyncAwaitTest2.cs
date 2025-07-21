using System;
using System.IO;
using System.Threading;
using UnityEngine;

public class AsyncAwaitTest2 : MonoBehaviour
{
    string filePath;
    string fileContents;

    private void Start()
    {
        // Applicaion.dataPath = Assets 폴더 경로
        filePath = Path.Combine(Application.dataPath, "Resources/File.txt");

        Thread thread = new Thread(() =>
        {
            Debug.Log("동기 실행");
            RoadFile();
        });

        thread.Start();
        Debug.Log("메인 스레드 진행 중");

        thread.Join(); // 스레드가 종료될 때까지 대기
        Debug.Log($"파일 읽기 완료 : {fileContents}");
    }

    private void RoadFile()
    {
        if (File.Exists(filePath))
        {
            fileContents = File.ReadAllText(filePath);
        }
    }
}
