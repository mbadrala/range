using System.Collections;
using UnityEngine;

public enum Vib { Success, Warning, Error, Light, Medium, Heavy }

public static class Vibration
{
    public static void Vibrate(long ms)
    {
#if UNITY_EDITOR
        Debug.Log("Vibrated: " + ms);
#elif UNITY_ANDROID
        VibrationAndroidHandler.Vibrate (ms);
#endif
    }

    public static void Vibrate(Vib v)
    {
#if UNITY_EDITOR
        Debug.Log("Vibrated: " + v);
#elif UNITY_ANDROID
        switch (v) {
            case Vib.Success:
                VibrationAndroidHandler.Vibrate (new long[] { 20, 20 }, -1);
                break;
            case Vib.Warning:
                VibrationAndroidHandler.Vibrate (new long[] { 10, 10 }, -1);
                break;
            case Vib.Error:
                VibrationAndroidHandler.Vibrate (new long[] { 20, 20, 20 }, -1);
                break;
            case Vib.Light:
                VibrationAndroidHandler.Vibrate (10);
                break;
            case Vib.Medium:
                VibrationAndroidHandler.Vibrate (15);
                break;
            case Vib.Heavy:
                VibrationAndroidHandler.Vibrate (20);
                break;
        }
#elif UNITY_IPHONE
        switch (v) {
            case Vib.Success:
                TapticPlugin.TapticManager.Notification (TapticPlugin.Notification.Success);
                break;
            case Vib.Warning:
                TapticPlugin.TapticManager.Notification (TapticPlugin.Notification.Warning);
                break;
            case Vib.Error:
                TapticPlugin.TapticManager.Notification (TapticPlugin.Notification.Error);
                break;
            case Vib.Light:
                TapticPlugin.TapticManager.Impact (TapticPlugin.Impact.Light);
                break;
            case Vib.Medium:
                TapticPlugin.TapticManager.Impact (TapticPlugin.Impact.Medium);
                break;
            case Vib.Heavy:
                TapticPlugin.TapticManager.Impact (TapticPlugin.Impact.Heavy);
                break;
        }
#endif
    }
}

static class VibrationAndroidHandler
{
#if UNITY_ANDROID && !UNITY_EDITOR
    public static AndroidJavaClass unityPlayer = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
    public static AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject> ("currentActivity");
    public static AndroidJavaObject vibrator = currentActivity.Call<AndroidJavaObject> ("getSystemService", "vibrator");
    public static AndroidJavaObject context = currentActivity.Call<AndroidJavaObject> ("getApplicationContext");
#endif

    public static void Vibrate(long milliseconds)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        vibrator.Call ("vibrate", milliseconds);
#endif
    }

    public static void Vibrate(long[] pattern, int rep)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        vibrator.Call ("vibrate", pattern, rep);
#endif
    }

    public static void Cancel()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        vibrator.Call ("cancel");
#endif
    }

    public static bool HasVibrator()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        AndroidJavaClass contextClass = new AndroidJavaClass ("android.content.Context");
        string Context_VIBRATOR_SERVICE = contextClass.GetStatic<string> ("VIBRATOR_SERVICE");
        AndroidJavaObject systemService = context.Call<AndroidJavaObject> ("getSystemService", Context_VIBRATOR_SERVICE);
        if (systemService.Call<bool> ("hasVibrator")) {
            return true;
        } else {
            return false;
        }
#else
        return false;
#endif
    }
    public static void Vibrate()
    {
#if UNITY_EDITOR
        Debug.Log("Vibrate");
#endif
        Handheld.Vibrate();
    }

}
