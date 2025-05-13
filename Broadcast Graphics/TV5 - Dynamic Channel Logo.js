//Declare Objects
//Logos
var Antenne_HG = ppFindObject("Antenne_HG");
var Antenne_HD = ppFindObject("Antenne_HD");
var Antenne_BG = ppFindObject("Antenne_BG");
var Antenne_BD = ppFindObject("Antenne_BD");
var Partner_HG = ppFindObject("Partner_HG");
var Partner_HD = ppFindObject("Partner_HD");
var Partner_BG = ppFindObject("Partner_BG");
var Partner_BD = ppFindObject("Partner_BD");
var Edition_HG = ppFindObject("Edition_HG");
var Edition_HD = ppFindObject("Edition_HD");
var Edition_BG = ppFindObject("Edition_BG");
var Edition_BD = ppFindObject("Edition_BD");
var CSA_HD = ppFindObject("CSA_HD");
var CSA_BD = ppFindObject("CSA_BD");
var CSA_Text_HD = ppFindObject("CSA_Text_HD");
var CSA_Text_BD = ppFindObject("CSA_Text_BD");
var Product_Group = ppFindObject("Product_Group");
var Product_Text_Group = ppFindObject("Product_Text_Group");
var Product_HD = ppFindObject("Product_HD");
var Product_BD = ppFindObject("Product_BD");
var Product_Text_HD = ppFindObject("Product_Text_HD");
var Product_Text_BD = ppFindObject("Product_Text_BD");
var Annonce_Sous_Titre = ppFindObject("Annonce_Sous_Titre");

//Custom Positions
var Antenne_Custom = ppFindObject("Antenne_Custom");
var Partner_Custom = ppFindObject("Partner_Custom");
var Edition_Custom = ppFindObject("Edition_Custom");

//Floating Position Fields
var Antenne_Position = ppFindFieldMarkerByFieldID(2);
var Antenne_Position_Custom = ppFindFieldMarkerByFieldID(3);
var Partner_Position = ppFindFieldMarkerByFieldID(12);
var Partner_Position_Custom = ppFindFieldMarkerByFieldID(13);
var Edition_Position = ppFindFieldMarkerByFieldID(22);
var Edition_Position_Custom = ppFindFieldMarkerByFieldID(23);
var CSA_Position = ppFindFieldMarkerByFieldID(32);
var Product_Position = ppFindFieldMarkerByFieldID(42);
var Product_Text_Position = ppFindFieldMarkerByFieldID(46);
var Product_Text_End = ppFindFieldMarkerByFieldID(47);

//Product logo Bools
var Product_Bool = ppFindFieldMarkerByFieldID(41);
var Product_Text_Bool = ppFindFieldMarkerByFieldID(45);

//Product End Opacity Keyframe
var Product_Text_Opacity = ppFindObject("Product_Text_Opacity");
//Set to 0 opacity at start
Product_Text_Opacity.value = 0;

//Floating CSA Fields
var CSA_Logo = ppFindFieldMarkerByFieldID(31);
var CSA_Text = ppFindFieldMarkerByFieldID(61);
var CSA_Text_Combined = ppFindFieldMarkerByFieldID(62);

//Combine CSA logo and CSA Text
ppSetFieldDataByFieldID(62, (CSA_Text.fieldMarker_FieldData + " " + CSA_Logo.fieldMarker_FieldData));

//Floating Annonce ST
var Annonce_ST_Data = ppFindFieldMarkerByFieldID(51);

//Timer Fields
var Antenne_Start_Offset = ppFindObject("Antenne_Start_Offset");
var Antenne_End_Offset = ppFindObject("Antenne_End_Offset");
var Partner_Start_Offset = ppFindObject("Partner_Start_Offset");
var Partner_End_Offset = ppFindObject("Partner_End_Offset");
var Edition_Start_Offset = ppFindObject("Edition_Start_Offset");
var Edition_End_Offset = ppFindObject("Edition_End_Offset");
var Product_End_Offset = ppFindObject("Product_End_Offset");

var Antenne_Start_Offset_Data = ppFindFieldMarkerByFieldID(4);
var Antenne_End_Offset_Data = ppFindFieldMarkerByFieldID(5);
var Partner_Start_Offset_Data = ppFindFieldMarkerByFieldID(14);
var Partner_End_Offset_Data = ppFindFieldMarkerByFieldID(15);
var Edition_Start_Offset_Data = ppFindFieldMarkerByFieldID(24);
var Edition_End_Offset_Data = ppFindFieldMarkerByFieldID(25);
var Product_End_Offset_Data = ppFindFieldMarkerByFieldID(48);

//Hide All logos
Antenne_HG.hidden = true;
Antenne_HD.hidden = true;
Antenne_BG.hidden = true;
Antenne_BD.hidden = true;
Antenne_Custom.hidden = true;
Partner_HG.hidden = true;
Partner_HD.hidden = true;
Partner_BG.hidden = true;
Partner_BD.hidden = true;
Partner_Custom.hidden = true;
Edition_HG.hidden = true;
Edition_HD.hidden = true;
Edition_BG.hidden = true;
Edition_BD.hidden = true;
Edition_Custom.hidden = true;
CSA_HD.hidden = true;
CSA_BD.hidden = true;
CSA_Text_HD.hidden = true;
CSA_Text_BD.hidden = true;
Product_Group.hidden = true;
Product_Text_Group.hidden = true;
Product_HD.hidden = true;
Product_BD.hidden = true;
Product_Text_HD.hidden = true;
Product_Text_BD.hidden = true;
Annonce_Sous_Titre.hidden = true;

//Set Logo Positions based on position fields
//Set Positions
if (Antenne_Position.fieldMarker_FieldData == "HG"){Antenne_HG.hidden = false;}
if (Antenne_Position.fieldMarker_FieldData == "HD"){Antenne_HD.hidden = false;}
if (Antenne_Position.fieldMarker_FieldData == "BG"){Antenne_BG.hidden = false;}
if (Antenne_Position.fieldMarker_FieldData == "BD"){Antenne_BD.hidden = false;}

if (Partner_Position.fieldMarker_FieldData == "HG"){Partner_HG.hidden = false;}
if (Partner_Position.fieldMarker_FieldData == "HD"){Partner_HD.hidden = false;}
if (Partner_Position.fieldMarker_FieldData == "BG"){Partner_BG.hidden = false;}
if (Partner_Position.fieldMarker_FieldData == "BD"){Partner_BD.hidden = false;}

if (Edition_Position.fieldMarker_FieldData == "HG"){Edition_HG.hidden = false;}
if (Edition_Position.fieldMarker_FieldData == "HD"){Edition_HD.hidden = false;}
if (Edition_Position.fieldMarker_FieldData == "BG"){Edition_BG.hidden = false;}
if (Edition_Position.fieldMarker_FieldData == "BD"){Edition_BD.hidden = false;}

//Custom XY Position
if (Antenne_Position_Custom.fieldMarker_FieldData != "")
{
	Antenne_Custom.hidden = false;
	var Antenne_Custom_XY = Antenne_Position_Custom.fieldMarker_FieldData.split('/');
	Antenne_Custom.position.x = -7.1111 + (Antenne_Custom_XY[0]/135);
	Antenne_Custom.position.y = -4 + (Antenne_Custom_XY[1]/135);

	Antenne_HG.hidden = true;
	Antenne_HD.hidden = true;
	Antenne_BG.hidden = true;
	Antenne_BD.hidden = true;
}

//Custom XY Position
if (Partner_Position_Custom.fieldMarker_FieldData != "")
{
	Partner_Custom.hidden = false;
	var Partner_Custom_XY = Partner_Position_Custom.fieldMarker_FieldData.split('/');
	Partner_Custom.position.x = -7.1111 + (Partner_Custom_XY[0]/135);
	Partner_Custom.position.y = -4 + (Partner_Custom_XY[1]/135);

	Partner_HG.hidden = true;
	Partner_HD.hidden = true;
	Partner_BG.hidden = true;
	Partner_BD.hidden = true;
}

//Custom XY Position
if (Edition_Position_Custom.fieldMarker_FieldData != "")
{
	Edition_Custom.hidden = false;
	var Edition_Custom_XY = Edition_Position_Custom.fieldMarker_FieldData.split('/');
	Edition_Custom.position.x = -7.1111 + (Edition_Custom_XY[0]/135);
	Edition_Custom.position.y = -4 + (Edition_Custom_XY[1]/135);

	Edition_HG.hidden = true;
	Edition_HD.hidden = true;
	Edition_BG.hidden = true;
	Edition_BD.hidden = true;
}

if (CSA_Position.fieldMarker_FieldData == "HD"){CSA_HD.hidden = false;}
if (CSA_Position.fieldMarker_FieldData == "BD"){CSA_BD.hidden = false;}

if (CSA_Position.fieldMarker_FieldData == "HD"){CSA_Text_HD.hidden = false;}
if (CSA_Position.fieldMarker_FieldData == "BD"){CSA_Text_BD.hidden = false;}

if (Product_Position.fieldMarker_FieldData == "HD"){Product_HD.hidden = false;}
if (Product_Position.fieldMarker_FieldData == "BD"){Product_BD.hidden = false;}
if (Product_Text_Position.fieldMarker_FieldData == "HD"){Product_Text_HD.hidden = false;}
if (Product_Text_Position.fieldMarker_FieldData == "BD"){Product_Text_BD.hidden = false;}

if (Product_Bool.fieldMarker_FieldData == "OUI"){Product_Group.hidden = false;}
if (Product_Text_Bool.fieldMarker_FieldData == "OUI"){Product_Text_Group.hidden = false;}
if (Product_Text_End.fieldMarker_FieldData == "OUI"){Product_Text_Opacity.value = 1;}



//Show Annonce ST
if (Annonce_ST_Data.fieldMarker_FieldData != "")
{
	Annonce_Sous_Titre.hidden = false;
}

//Set timing offsets based on field data
Antenne_Start_Offset.timeStr = Antenne_Start_Offset_Data.fieldMarker_FieldData;
Antenne_End_Offset.timeStr = Antenne_End_Offset_Data.fieldMarker_FieldData;
Partner_Start_Offset.timeStr = Partner_Start_Offset_Data.fieldMarker_FieldData;
Partner_End_Offset.timeStr = Partner_End_Offset_Data.fieldMarker_FieldData;
Edition_Start_Offset.timeStr = Edition_Start_Offset_Data.fieldMarker_FieldData;
Edition_End_Offset.timeStr = Edition_End_Offset_Data.fieldMarker_FieldData;
Product_End_Offset.timeStr = Product_End_Offset_Data.fieldMarker_FieldData;

//Override times lower than 00:00:00:03
if ((Antenne_Start_Offset_Data.fieldMarker_FieldData == "00:00:00:00")||
	(Antenne_Start_Offset_Data.fieldMarker_FieldData == "00:00:00:01")||
	(Antenne_Start_Offset_Data.fieldMarker_FieldData == "00:00:00:02"))
{
	Antenne_Start_Offset.timeStr = "00:00:00:03";
}
if ((Partner_Start_Offset_Data.fieldMarker_FieldData == "00:00:00:00")||
	(Partner_Start_Offset_Data.fieldMarker_FieldData == "00:00:00:01")||
	(Partner_Start_Offset_Data.fieldMarker_FieldData == "00:00:00:02"))
{
	Partner_Start_Offset.timeStr = "00:00:00:03";
}
if ((Edition_Start_Offset_Data.fieldMarker_FieldData == "00:00:00:00")||
	(Edition_Start_Offset_Data.fieldMarker_FieldData == "00:00:00:01")||
	(Edition_Start_Offset_Data.fieldMarker_FieldData == "00:00:00:02"))
{
	Edition_Start_Offset.timeStr = "00:00:00:03";
}

//Log Information
ppLog("Antenne Position = " + Antenne_Position.fieldMarker_FieldData);
ppLog("Antenne Position_Custom = " + Antenne_Position_Custom.fieldMarker_FieldData);
ppLog("Antenne Start Offset = " + Antenne_Start_Offset.timeStr);
ppLog("Antenne End Offset = " + Antenne_End_Offset.timeStr);

ppLog("Partner Position = " + Partner_Position.fieldMarker_FieldData);
ppLog("Partner Position_Custom = " + Partner_Position_Custom.fieldMarker_FieldData);
ppLog("Partner Start Offset = " + Partner_Start_Offset.timeStr);
ppLog("Partner End Offset = " + Partner_End_Offset.timeStr);

ppLog("Edition Position = " + Edition_Position.fieldMarker_FieldData);
ppLog("Edition Position_Custom = " + Edition_Position_Custom.fieldMarker_FieldData);
ppLog("Edition Start Offset = " + Edition_Start_Offset.timeStr);
ppLog("Edition End Offset = " + Edition_End_Offset.timeStr);

ppLog("CSA Position = " + CSA_Position.fieldMarker_FieldData);
ppLog("Product Position = " + Product_Position.fieldMarker_FieldData);


function ppOnUpdate()
{
	// Add code you want to run every update in here.
}


// Template for ppOnEvent

// 0-30 params - up to 10 string, 10 integer, 10 boolean

// function ppOnEventABC(n_IntParam, b_BoolParam, s_StringParam)

