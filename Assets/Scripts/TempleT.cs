using UnityEngine;
using UnityEngine.UI;

public sealed class TempleT : MonoBehaviour
{
	public Image icon;
	public Button button;
	public int xTemple;
	public int yTemple;
	private TempleTta _typeTemple;

	public TempleTd Data => new TempleTd(xTemple, yTemple, _typeTemple.aTemple);

	public TempleTta TypeTemple
	{
		get => _typeTemple;
		set
		{
			if (_typeTemple == value) return;
			_typeTemple = value;
			icon.sprite = _typeTemple.cTemple;
		}
	}
}