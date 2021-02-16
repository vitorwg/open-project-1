﻿using UnityEngine;
using UnityEngine.Localization;
/// <summary>
/// This class contains Settings specific to Locations only
/// </summary>

[CreateAssetMenu(fileName = "NewLocation", menuName = "Scene Data/Location")]
public class LocationSO : GameSceneSO, IDesc
{
	public LocalizedString locationName;
	public AudioClip musicTrack;
	public int enemiesCount; //Example variable, will change later

	[Header("Serialization")]
	[SerializeField] Uuid uuid;
	public Uuid DescId => uuid;
}
