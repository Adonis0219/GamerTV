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
        // Applicaion.dataPath = Assets ���� ���
        filePath = Path.Combine(Application.dataPath, "Resources/File.txt");
        Debug.Log("���� ������ ���� ��");

        fileContents = await ReadFileAsync(filePath);

        Debug.Log($"���� �б� �Ϸ� : {fileContents}");
    }

    async Task<string> ReadFileAsync(string path)
    {
        if (File.Exists(path))
        {
            return await Task.Run(() => File.ReadAllText(path));
        }
        return "������ �������� �ʽ��ϴ�.";
    }
}
