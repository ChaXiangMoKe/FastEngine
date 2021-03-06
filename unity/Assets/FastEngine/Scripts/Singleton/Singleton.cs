﻿/*
* @Author: 
* @Description:
* @Date: 2021-03-03 21:27:17
*/

namespace FastEngine
{
    public abstract class Singleton<T> : ISingleton where T : Singleton<T>
    {
        private static T _instance;
        private static readonly object Obj = new object();

        protected static T instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Obj)
                    {
                        if (_instance == null)
                        {
                            _instance = System.Activator.CreateInstance<T>();
                            _instance.InitializeSingleton();
                        }
                    }
                }
                return _instance;
            }
        }
        public virtual void Dispose()
        {
            _instance = null;
        }
        public virtual void InitializeSingleton() { }

        public static bool HasInstance() { return _instance != null; }
    }
}