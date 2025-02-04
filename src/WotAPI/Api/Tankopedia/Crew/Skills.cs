﻿using Newtonsoft.Json;

namespace WotAPI.Api.Tankopedia.Crew;

[Response("https://{region_site}/wot/encyclopedia/crewskills/")]
public class Skills : ResponseClass<Dictionary<string, Skills.CrewSkill>>
{
	public class CrewSkill
	{
		/// <summary>
		///     RU: Описание умения
		///     <para> EN: Skill description </para>
		/// </summary>
		[JsonProperty("description")] public string? Description;

		/// <summary>
		///     RU: URL к значку умения
		///     <para> EN: URL to skill icon </para>
		/// </summary>
		[JsonProperty("image_url")] public CrewSkillImages? Images;

		/// <summary>
		///     RU: Показывает, является ли навыком
		///     <para> EN: Indicates if it is a perk </para>
		/// </summary>
		[JsonProperty("is_perk")] public bool? IsPerk;

		/// <summary>
		///     RU: Название умения
		///     <para> EN: Skill name </para>
		/// </summary>
		[JsonProperty("name")] public string? Name;

		/// <summary>
		///     RU: Идентификатор умения
		///     <para> EN: Skill ID </para>
		/// </summary>
		[JsonProperty("skill")] public string? Skill;
	}


	public class CrewSkillImages
	{
		/// <summary>
		///     RU: URL к большому изображению
		///     <para> EN: URL to large image </para>
		/// </summary>
		[JsonProperty("big_icon")] public string? BigIcon;

		/// <summary>
		///     RU: URL к малому изображению
		///     <para> EN: URL to small image </para>
		/// </summary>
		[JsonProperty("small_icon")] public string? SmallIcon;
	}
}