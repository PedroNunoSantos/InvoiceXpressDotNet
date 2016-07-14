using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet.Enums
{
	public enum Country
	{
		[XmlEnum("")]
		None = 0,
		[XmlEnum(Name="Portugal")]
		Portugal,
		[XmlEnum(Name="Ireland")]
		Ireland,
		[XmlEnum(Name="UK")]
		UK,
		[XmlEnum(Name="Canada")]
		Canada,
		[XmlEnum(Name="United States")]
		UnitedStates,
		[XmlEnum(Name="Afghanistan")]
		Afghanistan,
		[XmlEnum(Name="Albania")]
		Albania,
		[XmlEnum(Name="Algeria")]
		Algeria,
		[XmlEnum(Name="American Samoa")]
		AmericanSamoa,
		[XmlEnum(Name="Andorra")]
		Andorra,
		[XmlEnum(Name="Angola")]
		Angola,
		[XmlEnum(Name="Anguilla")]
		Anguilla,
		[XmlEnum(Name="Antigua and Barbuda")]
		AntiguaAndBarbuda,
		[XmlEnum(Name="Argentina")]
		Argentina,
		[XmlEnum(Name="Armenia")]
		Armenia,
		[XmlEnum(Name="Aruba")]
		Aruba,
		[XmlEnum(Name="Australia")]
		Australia,
		[XmlEnum(Name="Austria")]
		Austria,
		[XmlEnum(Name="Azerbaijan")]
		Azerbaijan,
		[XmlEnum(Name="Bahamas")]
		Bahamas,
		[XmlEnum(Name="Bahrain")]
		Bahrain,
		[XmlEnum(Name="Bangladesh")]
		Bangladesh,
		[XmlEnum(Name="Barbados")]
		Barbados,
		[XmlEnum(Name="Belarus")]
		Belarus,
		[XmlEnum(Name="Belgium")]
		Belgium,
		[XmlEnum(Name="Belize")]
		Belize,
		[XmlEnum(Name="Benin")]
		Benin,
		[XmlEnum(Name="Bermuda")]
		Bermuda,
		[XmlEnum(Name="Bhutan")]
		Bhutan,
		[XmlEnum(Name="Bolivia")]
		Bolivia,
		[XmlEnum(Name="Bosnia-Herzegovina")]
		BosniaHerzegovina,
		[XmlEnum(Name="Botswana")]
		Botswana,
		[XmlEnum(Name="Brazil")]
		Brazil,
		[XmlEnum(Name="British Indian Ocean Territory")]
		BritishIndianOceanTerritory,
		[XmlEnum(Name="Brunei")]
		Brunei,
		[XmlEnum(Name="Bulgaria")]
		Bulgaria,
		[XmlEnum(Name="Burkina Faso")]
		BurkinaFaso,
		[XmlEnum(Name="Burma")]
		Burma,
		[XmlEnum(Name="Burundi")]
		Burundi,
		[XmlEnum(Name="Cambodia")]
		Cambodia,
		[XmlEnum(Name="Cameroon")]
		Cameroon,
		[XmlEnum(Name="Canton and Enderbury Islands")]
		CantonAndEnderburyIslands,
		[XmlEnum(Name="Cape Verde")]
		CapeVerde,
		[XmlEnum(Name="Cayman Islands")]
		CaymanIslands,
		[XmlEnum(Name="Central African Republic")]
		CentralAfricanRepublic,
		[XmlEnum(Name="Chad")]
		Chad,
		[XmlEnum(Name="Chile")]
		Chile,
		[XmlEnum(Name="China")]
		China,
		[XmlEnum(Name="Christmas Island")]
		ChristmasIsland,
		[XmlEnum(Name="Cocos (Keeling) Islands")]
		CocosKeelingIslands,
		[XmlEnum(Name="Colombia")]
		Colombia,
		[XmlEnum(Name="Comoros")]
		Comoros,
		[XmlEnum(Name="Congo")]
		Congo,
		[XmlEnum(Name="Congo, Democratic Republic")]
		CongoDemocraticRepublic,
		[XmlEnum(Name="Cook Islands")]
		CookIslands,
		[XmlEnum(Name="Costa Rica")]
		CostaRica,
		[XmlEnum(Name="Côte d’Ivoire")]
		CoteDIvoire,
		[XmlEnum(Name="Croatia")]
		Croatia,
		[XmlEnum(Name="Cuba")]
		Cuba,
		[XmlEnum(Name="Curaçao")]
		Curacao,
		[XmlEnum(Name="Cyprus")]
		Cyprus,
		[XmlEnum(Name="Czech Republic")]
		CzechRepublic,
		[XmlEnum(Name="Denmark")]
		Denmark,
		[XmlEnum(Name="Djibouti")]
		Djibouti,
		[XmlEnum(Name="Dominica")]
		Dominica,
		[XmlEnum(Name="Dominican Republic")]
		DominicanRepublic,
		[XmlEnum(Name="Dronning Maud Land")]
		DronningMaudLand,
		[XmlEnum(Name="East Timor")]
		EastTimor,
		[XmlEnum(Name="Ecuador")]
		Ecuador,
		[XmlEnum(Name="Egypt")]
		Egypt,
		[XmlEnum(Name="El Salvador")]
		ElSalvador,
		[XmlEnum(Name="Equatorial Guinea")]
		EquatorialGuinea,
		[XmlEnum(Name="Eritrea")]
		Eritrea,
		[XmlEnum(Name="Estonia")]
		Estonia,
		[XmlEnum(Name="Ethiopia")]
		Ethiopia,
		[XmlEnum(Name="Faeroe Islands (Føroyar)")]
		FaeroeIslandsFøroyar,
		[XmlEnum(Name="Falkland Islands")]
		FalklandIslands,
		[XmlEnum(Name="Fiji")]
		Fiji,
		[XmlEnum(Name="Finland")]
		Finland,
		[XmlEnum(Name="France")]
		France,
		[XmlEnum(Name="French Guiana")]
		FrenchGuiana,
		[XmlEnum(Name="French Polynesia")]
		FrenchPolynesia,
		[XmlEnum(Name="Gabon")]
		Gabon,
		[XmlEnum(Name="Gambia")]
		Gambia,
		[XmlEnum(Name="Georgia")]
		Georgia,
		[XmlEnum(Name="Germany")]
		Germany,
		[XmlEnum(Name="Ghana")]
		Ghana,
		[XmlEnum(Name="Gibraltar")]
		Gibraltar,
		[XmlEnum(Name="Great Britain")]
		GreatBritain,
		[XmlEnum(Name="Greece")]
		Greece,
		[XmlEnum(Name="Greenland")]
		Greenland,
		[XmlEnum(Name="Grenada")]
		Grenada,
		[XmlEnum(Name="Guadeloupe")]
		Guadeloupe,
		[XmlEnum(Name="Guam")]
		Guam,
		[XmlEnum(Name="Guatemala")]
		Guatemala,
		[XmlEnum(Name="Guernsey")]
		Guernsey,
		[XmlEnum(Name="Guinea-Bissau")]
		GuineaBissau,
		[XmlEnum(Name="Guinea")]
		Guinea,
		[XmlEnum(Name="Guyana")]
		Guyana,
		[XmlEnum(Name="Haiti")]
		Haiti,
		[XmlEnum(Name="Heard and McDonald Islands")]
		HeardAndMcDonaldIslands,
		[XmlEnum(Name="Honduras")]
		Honduras,
		[XmlEnum(Name="Hong Kong")]
		HongKong,
		[XmlEnum(Name="Hungary")]
		Hungary,
		[XmlEnum(Name="Iceland")]
		Iceland,
		[XmlEnum(Name="India")]
		India,
		[XmlEnum(Name="Indonesia")]
		Indonesia,
		[XmlEnum(Name="International Monetary Fund")]
		InternationalMonetaryFund,
		[XmlEnum(Name="Iran")]
		Iran,
		[XmlEnum(Name="Iraq")]
		Iraq,
		[XmlEnum(Name="Isle of Man")]
		IsleOfMan,
		[XmlEnum(Name="Israel")]
		Israel,
		[XmlEnum(Name="Italy")]
		Italy,
		[XmlEnum(Name="Ivory Coast")]
		IvoryCoast,
		[XmlEnum(Name="Jamaica")]
		Jamaica,
		[XmlEnum(Name="Japan")]
		Japan,
		[XmlEnum(Name="Jersey")]
		Jersey,
		[XmlEnum(Name="Johnston Island")]
		JohnstonIsland,
		[XmlEnum(Name="Jordan")]
		Jordan,
		[XmlEnum(Name="Kampuchea")]
		Kampuchea,
		[XmlEnum(Name="Kazakhstan")]
		Kazakhstan,
		[XmlEnum(Name="Kenya")]
		Kenya,
		[XmlEnum(Name="Kiribati")]
		Kiribati,
		[XmlEnum(Name="Korea, North")]
		KoreaNorth,
		[XmlEnum(Name="Korea, South")]
		KoreaSouth,
		[XmlEnum(Name="Kuwait")]
		Kuwait,
		[XmlEnum(Name="Kyrgyzstan")]
		Kyrgyzstan,
		[XmlEnum(Name="Laos")]
		Laos,
		[XmlEnum(Name="Latvia")]
		Latvia,
		[XmlEnum(Name="Lebanon")]
		Lebanon,
		[XmlEnum(Name="Lesotho")]
		Lesotho,
		[XmlEnum(Name="Liberia")]
		Liberia,
		[XmlEnum(Name="Libya")]
		Libya,
		[XmlEnum(Name="Liechtenstein")]
		Liechtenstein,
		[XmlEnum(Name="Lithuania")]
		Lithuania,
		[XmlEnum(Name="Luxembourg")]
		Luxembourg,
		[XmlEnum(Name="Macau")]
		Macau,
		[XmlEnum(Name="Macedonia (Former Yug. Rep.)")]
		MacedoniaFormerYugRep,
		[XmlEnum(Name="Madagascar")]
		Madagascar,
		[XmlEnum(Name="Malawi")]
		Malawi,
		[XmlEnum(Name="Malaysia")]
		Malaysia,
		[XmlEnum(Name="Maldives")]
		Maldives,
		[XmlEnum(Name="Mali")]
		Mali,
		[XmlEnum(Name="Malta")]
		Malta,
		[XmlEnum(Name="Marshall Islands")]
		MarshallIslands,
		[XmlEnum(Name="Martinique")]
		Martinique,
		[XmlEnum(Name="Mauritania")]
		Mauritania,
		[XmlEnum(Name="Mauritius")]
		Mauritius,
		[XmlEnum(Name="Mayotte")]
		Mayotte,
		[XmlEnum(Name="Micronesia")]
		Micronesia,
		[XmlEnum(Name="Midway Islands")]
		MidwayIslands,
		[XmlEnum(Name="Mexico")]
		Mexico,
		[XmlEnum(Name="Moldova")]
		Moldova,
		[XmlEnum(Name="Monaco")]
		Monaco,
		[XmlEnum(Name="Mongolia")]
		Mongolia,
		[XmlEnum(Name="Montenegro")]
		Montenegro,
		[XmlEnum(Name="Montserrat")]
		Montserrat,
		[XmlEnum(Name="Morocco")]
		Morocco,
		[XmlEnum(Name="Mozambique")]
		Mozambique,
		[XmlEnum(Name="Myanmar")]
		Myanmar,
		[XmlEnum(Name="Nauru")]
		Nauru,
		[XmlEnum(Name="Namibia")]
		Namibia,
		[XmlEnum(Name="Nepal")]
		Nepal,
		[XmlEnum(Name="Netherlands Antilles")]
		NetherlandsAntilles,
		[XmlEnum(Name="Netherlands")]
		Netherlands,
		[XmlEnum(Name="New Caledonia")]
		NewCaledonia,
		[XmlEnum(Name="New Zealand")]
		NewZealand,
		[XmlEnum(Name="Nicaragua")]
		Nicaragua,
		[XmlEnum(Name="Niger")]
		Niger,
		[XmlEnum(Name="Nigeria")]
		Nigeria,
		[XmlEnum(Name="Niue")]
		Niue,
		[XmlEnum(Name="Norfolk Island")]
		NorfolkIsland,
		[XmlEnum(Name="Northern Mariana Islands")]
		NorthernMarianaIslands,
		[XmlEnum(Name="Norway")]
		Norway,
		[XmlEnum(Name="Oman")]
		Oman,
		[XmlEnum(Name="Pakistan")]
		Pakistan,
		[XmlEnum(Name="Palau")]
		Palau,
		[XmlEnum(Name="Palestine")]
		Palestine,
		[XmlEnum(Name="Panama")]
		Panama,
		[XmlEnum(Name="Papua New Guinea")]
		PapuaNewGuinea,
		[XmlEnum(Name="Paraguay")]
		Paraguay,
		[XmlEnum(Name="Peru")]
		Peru,
		[XmlEnum(Name="Philippines")]
		Philippines,
		[XmlEnum(Name="Pitcairn Island")]
		PitcairnIsland,
		[XmlEnum(Name="Poland")]
		Poland,
		[XmlEnum(Name="Puerto Rico")]
		PuertoRico,
		[XmlEnum(Name="Qatar")]
		Qatar,
		[XmlEnum(Name="Reunion")]
		Reunion,
		[XmlEnum(Name="Romania")]
		Romania,
		[XmlEnum(Name="Russia")]
		Russia,
		[XmlEnum(Name="Rwanda")]
		Rwanda,
		[XmlEnum(Name="Samoa (Western)")]
		SamoaWestern,
		[XmlEnum(Name="Samoa (America)")]
		SamoaAmerica,
		[XmlEnum(Name="San Marino")]
		SanMarino,
		[XmlEnum(Name="São Tomé and Príncipe")]
		SaoTomeAndPrincipe,
		[XmlEnum(Name="Saudi Arabia")]
		SaudiArabia,
		[XmlEnum(Name="Sénégal")]
		Senegal,
		[XmlEnum(Name="Serbia")]
		Serbia,
		[XmlEnum(Name="Seychelles")]
		Seychelles,
		[XmlEnum(Name="Sierra Leone")]
		SierraLeone,
		[XmlEnum(Name="Singapore")]
		Singapore,
		[XmlEnum(Name="Slovakia")]
		Slovakia,
		[XmlEnum(Name="Slovenia")]
		Slovenia,
		[XmlEnum(Name="Solomon Islands")]
		SolomonIslands,
		[XmlEnum(Name="Somalia")]
		Somalia,
		[XmlEnum(Name="South Africa")]
		SouthAfrica,
		[XmlEnum(Name="Spain")]
		Spain,
		[XmlEnum(Name="Sri Lanka")]
		SriLanka,
		[XmlEnum(Name="St. Helena")]
		StHelena,
		[XmlEnum(Name="St. Kitts and Nevis")]
		StKittsAndNevis,
		[XmlEnum(Name="St. Lucia")]
		StLucia,
		[XmlEnum(Name="St. Vincent and the Grenadines")]
		StVincentAndTheGrenadines,
		[XmlEnum(Name="Sudan")]
		Sudan,
		[XmlEnum(Name="Suriname")]
		Suriname,
		[XmlEnum(Name="Svalbard and Jan Mayen Islands")]
		SvalbardAndJanMayenIslands,
		[XmlEnum(Name="Swaziland")]
		Swaziland,
		[XmlEnum(Name="Sweden")]
		Sweden,
		[XmlEnum(Name="Switzerland")]
		Switzerland,
		[XmlEnum(Name="Syria")]
		Syria,
		[XmlEnum(Name="Tahiti")]
		Tahiti,
		[XmlEnum(Name="Taiwan")]
		Taiwan,
		[XmlEnum(Name="Tajikistan")]
		Tajikistan,
		[XmlEnum(Name="Tanzania")]
		Tanzania,
		[XmlEnum(Name="Thailand")]
		Thailand,
		[XmlEnum(Name="Timor-Leste")]
		TimorLeste,
		[XmlEnum(Name="Togo")]
		Togo,
		[XmlEnum(Name="Trinidad and Tobago")]
		TrinidadAndTobago,
		[XmlEnum(Name="Tunisia")]
		Tunisia,
		[XmlEnum(Name="Turkey")]
		Turkey,
		[XmlEnum(Name="Turkmenistan")]
		Turkmenistan,
		[XmlEnum(Name="Turks and Caicos Islands")]
		TurksAndCaicosIslands,
		[XmlEnum(Name="Tuvalu")]
		Tuvalu,
		[XmlEnum(Name="Uganda")]
		Uganda,
		[XmlEnum(Name="Ukraine")]
		Ukraine,
		[XmlEnum(Name="United Arab Emirates")]
		UnitedArabEmirates,
		[XmlEnum(Name="Upper Volta")]
		UpperVolta,
		[XmlEnum(Name="Uruguay")]
		Uruguay,
		[XmlEnum(Name="Uzbekistan")]
		Uzbekistan,
		[XmlEnum(Name="Vanuatu")]
		Vanuatu,
		[XmlEnum(Name="Vatican")]
		Vatican,
		[XmlEnum(Name="Venezuela")]
		Venezuela,
		[XmlEnum(Name="Vietnam")]
		Vietnam,
		[XmlEnum(Name="Virgin Islands")]
		VirginIslands,
		[XmlEnum(Name="Wake Island")]
		WakeIsland,
		[XmlEnum(Name="Wallis and Futuna Islands")]
		WallisAndFutunaIslands,
		[XmlEnum(Name="Western Sahara")]
		WesternSahara,
		[XmlEnum(Name="Western Samoa")]
		WesternSamoa,
		[XmlEnum(Name="Yemen")]
		Yemen,
		[XmlEnum(Name="Zaïre")]
		Zaire,
		[XmlEnum(Name="Zambia")]
		Zambia,
		[XmlEnum(Name="Zimbabwe")]
		Zimbabwe,
	}
}
