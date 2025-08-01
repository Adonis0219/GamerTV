using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Utils : MonoBehaviour
{
    #region Time

    public static readonly WaitForFixedUpdate m_waitForFixedUpdate = new WaitForFixedUpdate();
    public static readonly WaitForEndOfFrame m_waitForEndOfFrame = new WaitForEndOfFrame();

    private static readonly Dictionary<float, WaitForSeconds> m_waitForSecondsCache = new Dictionary<float, WaitForSeconds>();
    
    public static WaitForSeconds GetWaitForSeconds(float seconds)
    {
        WaitForSeconds wfs;

        if (m_waitForSecondsCache.TryGetValue(seconds, out wfs))
        {
            return wfs;
        }
        else
        {
            wfs = new WaitForSeconds(seconds);
            m_waitForSecondsCache.Add(seconds, wfs);
            return wfs;
        }
    }

    #endregion

    #region Transform

    /// <summary>
    /// ���ϴ� ���� ������Ʈ�� Transform�� ã�� ��� �Լ�
    /// </summary>
    /// <param name="name">Ÿ�� �̸�</param>
    /// <param name="tr">���� ��ġ(���� Root)</param>
    /// <returns>ã�� Transform</returns>
    public static Transform FindChild(string name, Transform tr)
    {
        if (tr.name == name)
            return tr;

        for (int i = 0; i < tr.childCount; i++)
        {
            Transform findTr = FindChild(name, tr.GetChild(i));

            if (findTr != null)
                return findTr;
        }

        return null;
    }

    #endregion

    /// <summary>
    /// FindComponent Attribute�� ���� ������ �� ������Ʈ�� �������ִ� �Լ�
    /// </summary>
    public static void InjectComponents(object o)
    {
        Type type = o.GetType();
        MonoBehaviour script = o as MonoBehaviour;

        // static�� �ƴ� ��� �ʵ带 �����´�
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var field in fields)
        {
            // �ش� �ʵ忡 ������ Custom Atri�� ã�ƿ� �ʱ�ȭ �ϰ�
            var attribute = (FindComponentAttribute)field.GetCustomAttribute(typeof(FindComponentAttribute));

            // �˻�
            if (attribute == null)
            {
                Debug.Log($"�ʵ� '{field.Name}'�� ���� FindComponentAttribute�� �����ϴ�.");
                continue;   // �ش� field�� �Ѿ�� ���� field �˻�
            }

            // �ش� �ʵ��� Ÿ���� �����´� Ex) RigidBody, BoxCollider, ...
            Type fieldType = field.FieldType;
            // CA�� �����ڿ��� _gameObject�� �̸��� ���ڰ����� �̸� �ʱ�ȭ �ȴ�
            // type������ �ٷ� Transform ������ ������ �� �� ��� script ������ ����� �ʱ�ȭ
            Transform tr = FindChild(attribute._gameObjectName, script.transform);

            // �˻�
            if (tr == null)
            {
                Debug.Log($"���ӿ�����Ʈ '{attribute._gameObjectName}'�� Transform�� ã�� ���߽��ϴ�.");
                continue;
            }

            Component component = tr.GetComponent(fieldType);

            if (component == null)
            {
                Debug.Log($"���ӿ�����Ʈ '{attribute._gameObjectName}'���� '{fieldType}' ������Ʈ�� ã�� ���߽��ϴ�.");
                continue;
            }
            
            // script�� ���Ե� �ش� �ʵ��� ���� ã�� component�� �ʱ�ȭ ���ش�
            field.SetValue(script, component);
        }
    }
    
    /// <summary>
    /// FindComponent Attribute�� ���� ������ �� ������Ʈ�� �������ִ� �Լ�
    /// </summary>
    public static void InjectComponents2(object o)
    {
        Type type = o.GetType();
        MonoBehaviour script = o as MonoBehaviour;

        // static�� �ƴ� ��� �ʵ带 �����´�
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var field in fields)
        {
            // �ش� �ʵ忡 ������ Custom Atri�� ã�ƿ� �ʱ�ȭ �ϰ�
            var attribute = (FindComponentsAttribute)field.GetCustomAttribute(typeof(FindComponentsAttribute));

            // �˻�
            if (attribute == null)
            {
                Debug.Log($"�ʵ� '{field.Name}'�� ���� FindComponentAttribute�� �����ϴ�.");
                continue;   // �ش� field�� �Ѿ�� ���� field �˻�
            }

            // �ش� �ʵ��� Ÿ���� �����´� Ex) RigidBody, BoxCollider, ...
            Type fieldType = field.FieldType;

            // �ʵ尡 �迭�� ��� ó��
            if (fieldType.IsArray)
            {
                // �迭 ��� Ÿ�� �������� (�� : RigidBody[])
                Type elementType = fieldType.GetElementType();

                List<Component> compoList = new();

                foreach (var goName in attribute._gameObjectNames)
                {
                    Transform tr = FindChild(goName, script.transform);

                    if (tr == null)
                    {
                        Debug.Log($"���ӿ�����Ʈ '{goName}'�� Transform�� ã�� ���߽��ϴ�.");
                        continue;
                    }

                    Component component = tr.GetComponent(elementType);

                    if (component == null)
                    {
                        Debug.Log($"���ӿ�����Ʈ '{goName}'���� '{fieldType}' ������Ʈ�� ã�� ���߽��ϴ�.");
                        continue;
                    }
                    
                    compoList.Add(component);
                }
                
                // ���� �迭 ���� (������ �迭 Ÿ��, ����)
                Array compoArr = Array.CreateInstance(elementType, compoList.Count);

                for (int i = 0; i < compoList.Count; i++)
                {
                    // �迭�� �� �ε����� component���� �־��ش�
                    // �־��� ���, �־��� ��
                    compoArr.SetValue(compoList[i], i);
                }
                
                field.SetValue(script, compoArr);
            }
            // ���� ������Ʈ ó��
            else
            {
                // CA�� �����ڿ��� _gameObject�� �̸��� ���ڰ����� �̸� �ʱ�ȭ �ȴ�
                // type������ �ٷ� Transform ������ ������ �� �� ��� script ������ ����� �ʱ�ȭ
                Transform tr = FindChild(attribute._gameObjectNames[0], script.transform);

                // �˻�
                if (tr == null)
                {
                    Debug.Log($"���ӿ�����Ʈ '{attribute._gameObjectNames[0]}'�� Transform�� ã�� ���߽��ϴ�.");
                    continue;
                }

                Component component = tr.GetComponent(fieldType);

                if (component == null)
                {
                    Debug.Log($"���ӿ�����Ʈ '{attribute._gameObjectNames[0]}'���� '{fieldType}' ������Ʈ�� ã�� ���߽��ϴ�.");
                    continue;
                }
            
                // script�� ���Ե� �ش� �ʵ��� ���� ã�� component�� �ʱ�ȭ ���ش�
                field.SetValue(script, component);
            }
        }
    }
    
    public static void InjectComponents3(object o)
    {
        Type type = o.GetType();
        MonoBehaviour script = o as MonoBehaviour;

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var one in fields)
        {
            var attribute = (FindComponentsAttribute)one.GetCustomAttribute(typeof(FindComponentsAttribute));

            if (attribute == null)
            {
                Debug.Log($"�ʵ� '{one.Name}'�� ���� FindComponentAttribute�� �����ϴ�.");
                continue;
            }

            Type fieldType = one.FieldType;

            // �ʵ尡 �迭�� ��� ó��
            if (fieldType.IsArray)
            {
                // �迭 ��� Ÿ�� �������� (��: Rigidbody[])
                Type elementType = fieldType.GetElementType();

                List<Component> componentsList = new List<Component>();

                // ���� ���� ������Ʈ���� ������Ʈ ��������
                foreach (string gameObjectName in attribute._gameObjectNames)
                {
                    Transform tr = FindChild(gameObjectName, script.transform);

                    if (tr == null)
                    {
                        Debug.Log($"���ӿ�����Ʈ '{gameObjectName}'�� Transform�� ã�� ���߽��ϴ�.");
                        continue;
                    }

                    Component component = tr.GetComponent(elementType);
                    if (component == null)
                    {
                        Debug.Log($"���ӿ�����Ʈ '{gameObjectName}'���� '{elementType}' ������Ʈ�� ã�� ���߽��ϴ�.");
                        continue;
                    }

                    componentsList.Add(component);
                }

                Array componentArray = Array.CreateInstance(elementType, componentsList.Count);

                for (int i = 0; i < componentsList.Count; i++)
                {
                    componentArray.SetValue(componentsList[i], i);
                }

                one.SetValue(script, componentArray);
            }
            // �ʵ尡 List�� ��� ó��
            else if (fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(List<>))
            {
                // List�� ��� Ÿ�� �������� (��: List<Rigidbody>)
                Type elementType = fieldType.GetGenericArguments()[0];

                // ������Ʈ�� ������ List ����
                IList componentsList = (IList)Activator.CreateInstance(fieldType);

                foreach (string gameObjectName in attribute._gameObjectNames)
                {
                    Transform tr = FindChild(gameObjectName, script.transform);

                    if (tr == null)
                    {
                        Debug.Log($"���ӿ�����Ʈ '{gameObjectName}'�� Transform�� ã�� ���߽��ϴ�.");
                        continue;
                    }

                    Component component = tr.GetComponent(elementType);
                    if (component == null)
                    {
                        Debug.Log($"���ӿ�����Ʈ '{gameObjectName}'���� '{elementType}' ������Ʈ�� ã�� ���߽��ϴ�.");
                        continue;
                    }

                    componentsList.Add(component);
                }

                // �ʵ忡 List �Ҵ�
                one.SetValue(script, componentsList);
            }
            else
            {
                // ���� ������Ʈ ó��
                Transform tr = FindChild(attribute._gameObjectNames[0], script.transform);

                if (tr == null)
                {
                    Debug.Log($"���ӿ�����Ʈ '{attribute._gameObjectNames[0]}'�� Transform�� ã�� ���߽��ϴ�.");
                    continue;
                }

                Component component = tr.GetComponent(one.FieldType);

                if (component == null)
                {
                    Debug.Log($"���ӿ�����Ʈ '{attribute._gameObjectNames[0]}'���� '{one.FieldType}' ������Ʈ�� ã�� ���߽��ϴ�.");
                    continue;
                }

                one.SetValue(script, component);
            }
        }
    }

    public static void InjectComponents4(object o)
    {
        Type type = o.GetType();
        MonoBehaviour script = o as MonoBehaviour;

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var field in fields)
        {
            var attribute = (FindComponentsAttribute)field.GetCustomAttribute(typeof(FindComponentsAttribute));

            if (attribute == null)
            {
                Debug.Log($"�ʵ� '{field.Name}'�� ���� FindComponentAttribute�� �����ϴ�.");
                continue;
            }

            // �ʵ� Ÿ�Կ� ���� �б�
            if (field.FieldType.IsArray)
            {
                InjectArrayField(field, attribute, script);
            }
            else if (field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == typeof(List<>))
            {
                InjectListField(field, attribute, script);
            }
            else
            {
                InjectSingleComponent(field, attribute, script);
            }
        }
    }

    // �迭 �ʵ� ó��
    private static void InjectArrayField(FieldInfo field, FindComponentsAttribute attribute, MonoBehaviour script)
    {
        Type elementType = field.FieldType.GetElementType();
        List<Component> componentsList = GetComponentsFromGameObjects(attribute, elementType, script);

        Array componentArray = Array.CreateInstance(elementType, componentsList.Count);

        for (int i = 0; i < componentsList.Count; i++)
        {
            componentArray.SetValue(componentsList[i], i);
        }

        field.SetValue(script, componentArray);
    }

    // ����Ʈ �ʵ� ó��
    private static void InjectListField(FieldInfo field, FindComponentsAttribute attribute, MonoBehaviour script)
    {
        Type elementType = field.FieldType.GetGenericArguments()[0];
        IList componentsList = (IList)Activator.CreateInstance(field.FieldType);

        foreach (var component in GetComponentsFromGameObjects(attribute, elementType, script))
        {
            componentsList.Add(component);
        }

        field.SetValue(script, componentsList);
    }

    // ���� ������Ʈ �ʵ� ó��
    private static void InjectSingleComponent(FieldInfo field, FindComponentsAttribute attribute, MonoBehaviour script)
    {
        Transform tr = FindChild(attribute._gameObjectNames[0], script.transform);

        if (tr == null)
        {
            Debug.Log($"���ӿ�����Ʈ '{attribute._gameObjectNames[0]}'�� Transform�� ã�� ���߽��ϴ�.");
            return;
        }

        Component component = tr.GetComponent(field.FieldType);

        if (component == null)
        {
            Debug.Log($"���ӿ�����Ʈ '{attribute._gameObjectNames[0]}'���� '{field.FieldType}' ������Ʈ�� ã�� ���߽��ϴ�.");
            return;
        }

        field.SetValue(script, component);
    }

    // ���� ���� ������Ʈ���� ������Ʈ�� �������� ���� �Լ�
    private static List<Component> GetComponentsFromGameObjects(FindComponentsAttribute attribute, Type componentType, MonoBehaviour script)
    {
        List<Component> componentsList = new List<Component>();

        foreach (string gameObjectName in attribute._gameObjectNames)
        {
            Transform tr = FindChild(gameObjectName, script.transform);

            if (tr == null)
            {
                Debug.Log($"���ӿ�����Ʈ '{gameObjectName}'�� Transform�� ã�� ���߽��ϴ�.");
                continue;
            }

            Component component = tr.GetComponent(componentType);
            if (component == null)
            {
                Debug.Log($"���ӿ�����Ʈ '{gameObjectName}'���� '{componentType}' ������Ʈ�� ã�� ���߽��ϴ�.");
                continue;
            }

            componentsList.Add(component);
        }

        return componentsList;
    }
}
