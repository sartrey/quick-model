using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class Scene2Loader : MonoBehaviour {

	public Object CubePrefab = null;
	public Object SpherePrefab = null;
	public Object CylinderPrefab = null;
	public Object LabelPrefab = null;
	public int Factor = 1;

	private bool _IsLoading = false;
	private List<Object> _Entities
		= new List<Object>();
	private List<XElement> _Shapes
		= new List<XElement>();

	// Use this for initialization
	void Start () {
		GameObject.Find ("Detail").GetComponent<GUIText> ().text = "<detail>";
	}
	
	// Update is called once per frame
	void Update () {
        if (!_IsLoading)
        {
            if (Input.GetKey(KeyCode.R)) {
                _IsLoading = true;
                LoadStructure();
            }
        }
		if (Input.GetKey(KeyCode.C)) {
			foreach(var entity in _Entities) {
				Destroy (entity);
			}
			_Entities.Clear ();
			_Shapes.Clear ();
			_IsLoading = false;
		}
	}

	void LoadStructure() {
		string path = Path.Combine(Application.dataPath, "Temp\\fullmodel.xml");
		var xml = XElement.Load(path);
		var xml_arrange = xml.Element ("arrange");
		var txt_arrange = xml_arrange.Value;
		var txts_arrange = txt_arrange.Split (new char[]{','});

		var xmls_shape = xml.Element ("shapes").Elements ("shape");
		foreach (var xml_shape in xmls_shape)
			_Shapes.Add (xml_shape);

		var xml_layout = xml.Element ("layout");
		var xmls_point = xml_layout.Element("points").Elements("point");
		int index = 0;
		foreach (var xml_point in xmls_point) {
			var txt_coords = xml_point.Element("coords").Value;
			var txts_coord = txt_coords.Split (new char[]{','});
			var entity = CreateEntity(
				int.Parse (txts_arrange[index]) - 1,
				new Vector3(
					float.Parse (txts_coord[0]) * Factor,
					float.Parse (txts_coord[2]) * Factor,
					float.Parse (txts_coord[1]) * Factor));
			_Entities.Add (entity);
			index++;
		}
		var detail = string.Format ("layout:{0} arrange:{1}", 
		    xml_layout.Attribute ("index").Value,
		    xml_arrange.Attribute ("index").Value);
		GameObject.Find ("Detail").GetComponent<GUIText> ().text = detail;
	}

	Object CreateEntity(int index, Vector3 vector) {
		var shape = _Shapes[index];
		var type = shape.Element ("type").Value;
		var txts_translate = shape.Element ("translate").Value.Split (new char[]{','});
		var txts_scale = shape.Element ("scale").Value.Split (new char[]{','});
		var txts_rotate = shape.Element ("rotate").Value.Split (new char[]{','});
		var vec_translate = new Vector3 (
			float.Parse (txts_translate[0]), 
			float.Parse (txts_translate[2]), 
			float.Parse (txts_translate[1]));
		var vec_scale = new Vector3 (
			float.Parse (txts_scale[0]), 
			float.Parse (txts_scale[2]), 
			float.Parse (txts_scale[1]));
		var vec_rotate = new Vector3 (
			float.Parse (txts_rotate[0]), 
			float.Parse (txts_rotate[2]), 
			float.Parse (txts_rotate[1]));
		GameObject entity = null;
		switch (type) {
			case "cube":
				entity = Instantiate (CubePrefab, vector, Quaternion.identity) as GameObject;
				break;
			case "sphere":
				entity = Instantiate (SpherePrefab, vector, Quaternion.identity) as GameObject;
				break;
			case "cylinder":
				entity = Instantiate (CylinderPrefab, vector, Quaternion.identity) as GameObject;
				break;
		}
		string file = Path.Combine(Application.dataPath, "Temp\\entity" + index + ".png");
		if(File.Exists (file)) {
			var www = new WWW("file://" + file);
			entity.renderer.material.mainTexture = www.texture;
			entity.renderer.material.color = new Color(1.0f, 1.0f, 1.0f, 0.9f);
		}
		entity.transform.Translate(vec_translate);
		entity.transform.localScale = vec_scale;
		entity.transform.Rotate(vec_rotate);
		return entity;
	}
}
