using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class Scene1Loader : MonoBehaviour {

	public Object EntityPrefab = null;
	public Object LabelPrefab = null;
	public int Factor = 2;

	private bool _IsLoading = false;
    private List<XElement> _Models 
        = new List<XElement>();
	private List<Object> _Entities
		= new List<Object>();
    private int _CurrentModel = 0;

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
                LoadAllStructures();
                LoadStructure(0);
            }
            if (Input.GetKey(KeyCode.N)) {
                _IsLoading = true;
                _CurrentModel++;
                _CurrentModel = (_CurrentModel >= _Models.Count ? _Models.Count - 1 : _CurrentModel);
                LoadStructure(_CurrentModel);
            }
            if (Input.GetKey(KeyCode.P)) {
                _IsLoading = true;
                _CurrentModel--;
                _CurrentModel = (_CurrentModel < 0 ? 0 : _CurrentModel);
                LoadStructure(_CurrentModel);
            }
        }
		if (Input.GetKey(KeyCode.C)) {
			foreach(var entity in _Entities) {
				Destroy (entity);
			}
			_Entities.Clear ();
			_IsLoading = false;
		}
	}
	
	void LoadAllStructures() {
        _Models.Clear();
        string path = Path.Combine(Application.dataPath, "Temp");
        var files = Directory.GetFiles(path, "model*.xml");
        int total = files.Length;
        for (int i = 0; i < total; i++) {
            var file = Path.Combine(path, "model" + (i + 1) + ".xml");
            var xml = XElement.Load(file);
            _Models.Add(xml);
        }
    }

	void LoadStructure(int index) {
		var xml = _Models[index];
		var xml_arrange = xml.Element ("arrange");
		var xml_layout = xml.Element ("layout");
		var txt_arrange = xml_arrange.Value;
		var txts_arrange = txt_arrange.Split (new char[]{','});
		var xmls_point = xml_layout.Element("points").Elements("point");
		foreach (var xml_point in xmls_point) {
			var txt_coords = xml_point.Element("coords").Value;
			var txts_coord = txt_coords.Split (new char[]{','});
			var new_cube = Instantiate (EntityPrefab, 
			    new Vector3(
					float.Parse (txts_coord[0]) * Factor,
					float.Parse (txts_coord[2]) * Factor,
					float.Parse (txts_coord[1]) * Factor), 
			    Quaternion.identity);
			(new_cube as GameObject).renderer.material.color 
				= new Color(1.0f, 1.0f, 1.0f, 0.9f);
			var new_text = Instantiate (LabelPrefab, 
				new Vector3(
					float.Parse (txts_coord[0]) * Factor - 0.4f,
					float.Parse (txts_coord[2]) * Factor + 0.5f,
					float.Parse (txts_coord[1]) * Factor), 
			    Quaternion.identity);
			var text_mesh = (new_text as GameObject).GetComponent<TextMesh>();
			text_mesh.text = txts_arrange[int.Parse (xml_point.Attribute("id").Value)];
			_Entities.Add (new_cube);
			_Entities.Add (new_text);
		}
		var detail = string.Format ("layout:{0} arrange:{1} model:{2}", 
		    xml_layout.Attribute ("index").Value,
		    xml_arrange.Attribute ("index").Value,
		    index + 1);
		GameObject.Find ("Detail").GetComponent<GUIText> ().text = detail;
	}
}
