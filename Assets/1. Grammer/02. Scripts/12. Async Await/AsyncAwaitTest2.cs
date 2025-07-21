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
        // Applicaion.dataPath = Assets ���� ���
        filePath = Path.Combine(Application.dataPath, "Resources/File.txt");

        Thread thread = new Thread(() =>
        {
            Debug.Log("���� ����");
            RoadFile();
        });

        thread.Start();
        Debug.Log("���� ������ ���� ��");

        thread.Join(); // �����尡 ����� ������ ���
        Debug.Log($"���� �б� �Ϸ� : {fileContents}");
    }

    private void RoadFile()
    {
        if (File.Exists(filePath))
        {
            fileContents = File.ReadAllText(filePath);
        }
    }
}
