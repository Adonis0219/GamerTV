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
    /// 원하는 게임 오브젝트의 Transform을 찾는 재귀 함수
    /// </summary>
    /// <param name="name">타겟 이름</param>
    /// <param name="tr">시작 위치(보통 Root)</param>
    /// <returns>찾은 Transform</returns>
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
    /// FindComponent Attribute가 붙은 변수에 각 컴포넌트를 주입해주는 함수
    /// </summary>
    public static void InjectComponents(object o)
    {
        Type type = o.GetType();
        MonoBehaviour script = o as MonoBehaviour;

        // static이 아닌 모든 필드를 가져온다
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var field in fields)
        {
            // 해당 필드에 부착된 Custom Atri를 찾아와 초기화 하고
            var attribute = (FindComponentAttribute)field.GetCustomAttribute(typeof(FindComponentAttribute));

            // 검사
            if (attribute == null)
            {
                Debug.Log($"필드 '{field.Name}'에 대해 FindComponentAttribute가 없습니다.");
                continue;   // 해당 field는 넘어가고 다음 field 검사
            }

            // 해당 필드의 타입을 가져온다 Ex) RigidBody, BoxCollider, ...
            Type fieldType = field.FieldType;
            // CA의 생성자에서 _gameObject의 이름은 인자값으로 미리 초기화 된다
            // type에서는 바로 Transform 정보를 가지고 올 수 없어서 script 변수를 만들고 초기화
            Transform tr = FindChild(attribute._gameObjectName, script.transform);

            // 검사
            if (tr == null)
            {
                Debug.Log($"게임오브젝트 '{attribute._gameObjectName}'의 Transform을 찾지 못했습니다.");
                continue;
            }

            Component component = tr.GetComponent(fieldType);

            if (component == null)
            {
                Debug.Log($"게임오브젝트 '{attribute._gameObjectName}'에서 '{fieldType}' 컴포넌트를 찾지 못했습니다.");
                continue;
            }
            
            // script에 포함된 해당 필드의 값을 찾은 component로 초기화 해준다
            field.SetValue(script, component);
        }
    }
    
    /// <summary>
    /// FindComponent Attribute가 붙은 변수에 각 컴포넌트를 주입해주는 함수
    /// </summary>
    public static void InjectComponents2(object o)
    {
        Type type = o.GetType();
        MonoBehaviour script = o as MonoBehaviour;

        // static이 아닌 모든 필드를 가져온다
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var field in fields)
        {
            // 해당 필드에 부착된 Custom Atri를 찾아와 초기화 하고
            var attribute = (FindComponentsAttribute)field.GetCustomAttribute(typeof(FindComponentsAttribute));

            // 검사
            if (attribute == null)
            {
                Debug.Log($"필드 '{field.Name}'에 대해 FindComponentAttribute가 없습니다.");
                continue;   // 해당 field는 넘어가고 다음 field 검사
            }

            // 해당 필드의 타입을 가져온다 Ex) RigidBody, BoxCollider, ...
            Type fieldType = field.FieldType;

            // 필드가 배열인 경우 처리
            if (fieldType.IsArray)
            {
                // 배열 요소 타입 가져오기 (예 : RigidBody[])
                Type elementType = fieldType.GetElementType();

                List<Component> compoList = new();

                foreach (var goName in attribute._gameObjectNames)
                {
                    Transform tr = FindChild(goName, script.transform);

                    if (tr == null)
                    {
                        Debug.Log($"게임오브젝트 '{goName}'의 Transform을 찾지 못했습니다.");
                        continue;
                    }

                    Component component = tr.GetComponent(elementType);

                    if (component == null)
                    {
                        Debug.Log($"게임오브젝트 '{goName}'에서 '{fieldType}' 컴포넌트를 찾지 못했습니다.");
                        continue;
                    }
                    
                    compoList.Add(component);
                }
                
                // 동적 배열 생성 (생성할 배열 타입, 길이)
                Array compoArr = Array.CreateInstance(elementType, compoList.Count);

                for (int i = 0; i < compoList.Count; i++)
                {
                    // 배열의 각 인덱스에 component들을 넣어준다
                    // 넣어줄 대상, 넣어줄 값
                    compoArr.SetValue(compoList[i], i);
                }
                
                field.SetValue(script, compoArr);
            }
            // 단일 컴포넌트 처리
            else
            {
                // CA의 생성자에서 _gameObject의 이름은 인자값으로 미리 초기화 된다
                // type에서는 바로 Transform 정보를 가지고 올 수 없어서 script 변수를 만들고 초기화
                Transform tr = FindChild(attribute._gameObjectNames[0], script.transform);

                // 검사
                if (tr == null)
                {
                    Debug.Log($"게임오브젝트 '{attribute._gameObjectNames[0]}'의 Transform을 찾지 못했습니다.");
                    continue;
                }

                Component component = tr.GetComponent(fieldType);

                if (component == null)
                {
                    Debug.Log($"게임오브젝트 '{attribute._gameObjectNames[0]}'에서 '{fieldType}' 컴포넌트를 찾지 못했습니다.");
                    continue;
                }
            
                // script에 포함된 해당 필드의 값을 찾은 component로 초기화 해준다
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
                Debug.Log($"필드 '{one.Name}'에 대해 FindComponentAttribute가 없습니다.");
                continue;
            }

            Type fieldType = one.FieldType;

            // 필드가 배열인 경우 처리
            if (fieldType.IsArray)
            {
                // 배열 요소 타입 가져오기 (예: Rigidbody[])
                Type elementType = fieldType.GetElementType();

                List<Component> componentsList = new List<Component>();

                // 여러 게임 오브젝트에서 컴포넌트 가져오기
                foreach (string gameObjectName in attribute._gameObjectNames)
                {
                    Transform tr = FindChild(gameObjectName, script.transform);

                    if (tr == null)
                    {
                        Debug.Log($"게임오브젝트 '{gameObjectName}'의 Transform을 찾지 못했습니다.");
                        continue;
                    }

                    Component component = tr.GetComponent(elementType);
                    if (component == null)
                    {
                        Debug.Log($"게임오브젝트 '{gameObjectName}'에서 '{elementType}' 컴포넌트를 찾지 못했습니다.");
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
            // 필드가 List인 경우 처리
            else if (fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(List<>))
            {
                // List의 요소 타입 가져오기 (예: List<Rigidbody>)
                Type elementType = fieldType.GetGenericArguments()[0];

                // 컴포넌트를 저장할 List 생성
                IList componentsList = (IList)Activator.CreateInstance(fieldType);

                foreach (string gameObjectName in attribute._gameObjectNames)
                {
                    Transform tr = FindChild(gameObjectName, script.transform);

                    if (tr == null)
                    {
                        Debug.Log($"게임오브젝트 '{gameObjectName}'의 Transform을 찾지 못했습니다.");
                        continue;
                    }

                    Component component = tr.GetComponent(elementType);
                    if (component == null)
                    {
                        Debug.Log($"게임오브젝트 '{gameObjectName}'에서 '{elementType}' 컴포넌트를 찾지 못했습니다.");
                        continue;
                    }

                    componentsList.Add(component);
                }

                // 필드에 List 할당
                one.SetValue(script, componentsList);
            }
            else
            {
                // 단일 컴포넌트 처리
                Transform tr = FindChild(attribute._gameObjectNames[0], script.transform);

                if (tr == null)
                {
                    Debug.Log($"게임오브젝트 '{attribute._gameObjectNames[0]}'의 Transform을 찾지 못했습니다.");
                    continue;
                }

                Component component = tr.GetComponent(one.FieldType);

                if (component == null)
                {
                    Debug.Log($"게임오브젝트 '{attribute._gameObjectNames[0]}'에서 '{one.FieldType}' 컴포넌트를 찾지 못했습니다.");
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
                Debug.Log($"필드 '{field.Name}'에 대해 FindComponentAttribute가 없습니다.");
                continue;
            }

            // 필드 타입에 따라 분기
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

    // 배열 필드 처리
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

    // 리스트 필드 처리
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

    // 단일 컴포넌트 필드 처리
    private static void InjectSingleComponent(FieldInfo field, FindComponentsAttribute attribute, MonoBehaviour script)
    {
        Transform tr = FindChild(attribute._gameObjectNames[0], script.transform);

        if (tr == null)
        {
            Debug.Log($"게임오브젝트 '{attribute._gameObjectNames[0]}'의 Transform을 찾지 못했습니다.");
            return;
        }

        Component component = tr.GetComponent(field.FieldType);

        if (component == null)
        {
            Debug.Log($"게임오브젝트 '{attribute._gameObjectNames[0]}'에서 '{field.FieldType}' 컴포넌트를 찾지 못했습니다.");
            return;
        }

        field.SetValue(script, component);
    }

    // 여러 게임 오브젝트에서 컴포넌트를 가져오는 공통 함수
    private static List<Component> GetComponentsFromGameObjects(FindComponentsAttribute attribute, Type componentType, MonoBehaviour script)
    {
        List<Component> componentsList = new List<Component>();

        foreach (string gameObjectName in attribute._gameObjectNames)
        {
            Transform tr = FindChild(gameObjectName, script.transform);

            if (tr == null)
            {
                Debug.Log($"게임오브젝트 '{gameObjectName}'의 Transform을 찾지 못했습니다.");
                continue;
            }

            Component component = tr.GetComponent(componentType);
            if (component == null)
            {
                Debug.Log($"게임오브젝트 '{gameObjectName}'에서 '{componentType}' 컴포넌트를 찾지 못했습니다.");
                continue;
            }

            componentsList.Add(component);
        }

        return componentsList;
    }
}
