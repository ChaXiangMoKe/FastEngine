using System.Collections;
using UnityEngine;

namespace FastEngine.Core
{
    /// <summary>
    /// AssetBundle 资源
    /// </summary>
    public class BundleRes : Res, IPoolObject
    {

        public AssetBundleCreateRequest mRequest;

        private BundleRes[] _mDependencies;

        private int _mDependWaitCount;

        /// <summary>
        /// 分配对象
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static BundleRes Allocate(ResData data)
        {
            var res = ObjectPool<BundleRes>.instance.Allocate();
            res.Init(data);
            return res;
        }
        public bool isRecycled { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public override bool LoadAsync()
        {
            throw new System.NotImplementedException();
        }

        public override bool LoadSync()
        {
            throw new System.NotImplementedException();
        }

        public void Recycle()
        {
            throw new System.NotImplementedException();
        }

        public override void Unload()
        {
            throw new System.NotImplementedException();
        }

        protected override void OnZeroRef()
        {
            throw new System.NotImplementedException();
        }

        public void Init(ResData data)
        {
            mBundleName = data.bundleName;
            mState = ResState.Waiting;
            mType = ResType.Bundle;
            mAsset = null;
            mAssetBundle = null;
        }
    }
}