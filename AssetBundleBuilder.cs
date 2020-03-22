using System.Collections.Generic;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BundleBuilder : Editor
{
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
//Default output folder is C:\
        BuildPipeline.BuildAssetBundles(@"C:\", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.Android);
    }
}
