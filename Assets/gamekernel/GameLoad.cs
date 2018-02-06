// using UnityEngine;
// using UnityEditor;
// using System.IO;
// using System.Collections;

// public class GameLoad : MonoBehaviour {
//     public string yishuan;
//     public string classroom;
//     public string ronhuan;
//     public string nahan;
//     // public string[] allStage;

//     public TextAsset file;
//     [MenuItem("Tools/Write file")]
//     static void WriteString()
//     {
//         string path = "Assets/gamekernel/gameremember.txt";

//         //Write some text to the test.txt file
//         StreamWriter writer = new StreamWriter(path, true);
//         writer.WriteLine("Test");
//         writer.Close();
//     }

//     [MenuItem("Tools/Flush file")]
//     /**
//      *  清空檔案
//      */
//     static void Flush()
//     {
//         string path = "Assets/gamekernel/gameremember.txt";
//         StreamWriter flush = new StreamWriter(path);
//         flush.Flush();
//         flush.Close();
//     }


//     void Start () {
//         string fileData = file.ToString();
//         string[] fileArray = fileData.Split('\n');
//         classroom = fileArray[0];
//         yishuan = fileArray[1];
//         nahan = fileArray[3];
//         ronhuan = fileArray[2];
//     }

//     // Update is called once per frame
//     void Update () {

//     }
// }
