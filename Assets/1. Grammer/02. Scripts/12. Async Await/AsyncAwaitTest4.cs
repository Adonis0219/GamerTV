using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncAwaitTest4 : MonoBehaviour
{
    string filePath;
    string fileContents;

    async void Start()
    {
        // Applicaion.dataPath = Assets 폴더 경로
        filePath = Path.Combine(Application.dataPath, "Resources/File.txt");
        Debug.Log("메인 스레드 진행 중");

        fileContents = await ReadFileAsync(filePath);

        Debug.Log($"파일 읽기 완료 : {fileContents}");
    }

    async Task<string> ReadFileAsync(string path)
    {
        if (File.Exists(path))
        {
            return await Task.Run(() => File.ReadAllText(path));
        }
        return "파일이 존재하지 않습니다.";
    }
}
