using UnityEngine;

namespace XFramework.Unity
{
    public class UnityLogDriver : MonoBehaviour, ILogDriver
    {
        private void Awake()
        {
            XLog.RegisterDriver(this);
        }

        public void Debug(string message)
        {
            UnityEngine.Debug.Log("[Debug] " + message);
        }

        public void Info(string message)
        {
            UnityEngine.Debug.Log(message);
        }

        public void Warning(string message)
        {
            UnityEngine.Debug.LogWarning(message);
        }

        public void Error(string message)
        {
            UnityEngine.Debug.LogError(message);
        }

        public void Fatal(string message)
        {
            UnityEngine.Debug.LogError("[Fatal] " + message);
        }
    }
}