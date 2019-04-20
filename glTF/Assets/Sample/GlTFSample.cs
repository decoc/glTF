using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityGlTF;

public class GlTFSample:MonoBehaviour {

    private void Start()
    {
        StartCoroutine(Serialize());
    }

    public IEnumerator Serialize()
    {
        var path = Path.Combine(
            Application.streamingAssetsPath,
            "cat.gltf");

        var request = UnityWebRequest.Get(path);
        yield return request.SendWebRequest();

        var json = request.downloadHandler.text;

        Debug.Log($"json: {json}");

        var gltf = JsonUtility.FromJson<GlTFObject>(json);


        foreach (var scene in gltf.scenes)
        foreach (var sceneNode in scene.nodes)
            Debug.Log($"node index: {sceneNode}");

        foreach (var node in gltf.nodes)
        {
            Debug.Log($"camera: {node.camera}");

            var pos = new Vector3(node.translation[0], node.translation[1], node.translation[2]);
            var rot = new Quaternion(node.rotation[0], node.rotation[1], node.rotation[2], node.rotation[3]);
            var scl = new Vector3(node.scale[0], node.scale[1], node.scale[2]);
            Debug.Log($"{pos},{rot},{scl}");
        }
    }
}
