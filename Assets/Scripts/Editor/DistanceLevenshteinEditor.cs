using UnityEditor;
using UnityEngine;

namespace Editor
{
  public class DistanceLevenshteinEditor : EditorWindow
  {
    public string firstWord;
    public string secondWord;

    private SerializedObject _obj;
    private SerializedProperty _propFirstWord;
    private SerializedProperty _propSecondWord;

    private void OnEnable()
    {
      SetProps();
    }

    private void OnGUI()
    {
      _obj.Update();
      DrawBlockGUI("First word", _propFirstWord);
      DrawBlockGUI("Second word", _propSecondWord);
      DrawButtonGUI();

      if (_obj.ApplyModifiedProperties()) SceneView.RepaintAll();
    }

    [MenuItem("Tools/Distance Levenshtein")]
    public static void ShowWindow()
    {
      EditorWindow window = GetWindow(typeof(DistanceLevenshteinEditor), true, "Distance Levenshtein");
      window.position.Set(window.position.x, window.position.y, 300, 0);
      window.Show();
    }

    private void SetProps()
    {
      _obj = new SerializedObject(this);
      _propFirstWord = _obj.FindProperty(nameof(firstWord));
      _propSecondWord = _obj.FindProperty(nameof(secondWord));
    }

    private void DrawButtonGUI()
    {
      EditorGUILayout.Separator();
      if (GUILayout.Button(nameof(Execute))) Execute();
    }

    private static void DrawBlockGUI(string name, SerializedProperty prop)
    {
      EditorGUILayout.BeginHorizontal("box");
      EditorGUILayout.LabelField(name, GUILayout.Width(100));
      EditorGUILayout.PropertyField(prop, GUIContent.none);
      EditorGUILayout.EndHorizontal();
    } 
    
    // ReSharper disable Unity.PerformanceAnalysis
    private void Execute()
    {
      var algorithm = new DistanceLevenshtein.DistanceLevenshtein();
      Debug.Log($"Result of Levenshtein: {algorithm.Execute(firstWord, secondWord).ToString()}");
    }
  }
}