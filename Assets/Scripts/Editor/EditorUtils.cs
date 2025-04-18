using System.IO;
using UnityEngine;
using UnityEditor;

public static class EditorUtils
{
    [MenuItem("Utils/Screenshot")]
    public static void Screenshot()
    {
        string path = "Screenshots/";
        string name = "Screenshot" + System.DateTime.Now.ToString("_yyyy-MM-dd_hh-mm-ss");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        string fileName = path + "/" + name + ".png";
        ScreenCapture.CaptureScreenshot(fileName, 1);
    }
}
