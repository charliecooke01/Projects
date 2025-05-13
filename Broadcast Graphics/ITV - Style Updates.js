//Declare Objects
//Hidden Objects
const Channel_Object = ppFindObject("Hidden_Channel");
const KeyArt = ppFindObject("Hidden_KeyArt");
const TitleArt = ppFindObject("Hidden_TitleArt");
const Hidden_Style = ppFindObject("Hidden_Style");
const Hidden_Title = ppFindObject("Hidden_Title");
const Hidden_Extra_Info = ppFindObject("Hidden_Extra_Info");
const Hidden_Time = ppFindObject("Hidden_Time");

//Right hand 'Time' objects. Multiple timed versions depending on art available
const Time = ppFindObject("Time");
const Time_TA_KA = ppFindObject("Time_TA_KA");
const Time_TA_NA = ppFindObject("Time_TA_NA");

//String ("KA" or "NA") determining if key art exists set to KA by default
var KA_Check = "KA";

//Set 'Channel' Text to always be uppercase
const Channel = Channel_Object.cell.string.toUpperCase();

//------------------------------------------------------------------
//Objects to hide/show based on art available
//Key Art Groups
const Key_Art_Group = ppFindObject("Key_Art_Group");
const No_Key_Art_Group = ppFindObject("No_Key_Art_Group");
//Title Art
const TitleArt_Left = ppFindObject("TitleArt_Left");
const TitleArt_Centre = ppFindObject("TitleArt_Centre");

//------------------------------------------------------------------
//Text titles with Key Art
//Groups
const Group_Title_Text = ppFindObject("Group_Title_Text");
const Group_Title_2_Line = ppFindObject("Group_Title_2_Line");
const Group_Title_3_Line = ppFindObject("Group_Title_3_Line");
const Group_Title_4_Line = ppFindObject("Group_Title_4_Line");
const Group_Title_5_Line = ppFindObject("Group_Title_5_Line");
//1 Line
const Title_1_Line = ppFindObject("Title_1_Line");
//2 Line
const Title_2_Line_01 = ppFindObject("Title_2_Line_01");
const Title_2_Line_02 = ppFindObject("Title_2_Line_02");
const Title_2_Line_03 = ppFindObject("Title_2_Line_03");
const Title_2_Line_04 = ppFindObject("Title_2_Line_04");
//3 Line
const Title_3_Line_01 = ppFindObject("Title_3_Line_01");
const Title_3_Line_02 = ppFindObject("Title_3_Line_02");
const Title_3_Line_03 = ppFindObject("Title_3_Line_03");
//4 Line
const Title_4_Line_01 = ppFindObject("Title_4_Line_01");
const Title_4_Line_02 = ppFindObject("Title_4_Line_02");
const Title_4_Line_03 = ppFindObject("Title_4_Line_03");
const Title_4_Line_04 = ppFindObject("Title_4_Line_04");
//5 Line
const Title_5_Line_01 = ppFindObject("Title_5_Line_01");
const Title_5_Line_02 = ppFindObject("Title_5_Line_02");
const Title_5_Line_03 = ppFindObject("Title_5_Line_03");
const Title_5_Line_04 = ppFindObject("Title_5_Line_04");
const Title_5_Line_05 = ppFindObject("Title_5_Line_05");

//------------------------------------------------------------------
//Title Styles
//ITV1
const Style_ITV1_1_Line = "<span style=\"font-family:'ITV Display Sans Regular';letter-spacing:-0.013;font-size:3.33;\">";
const Style_ITV1_2_Line = "<span style=\"font-family:'ITV Display Sans Regular';letter-spacing:-0.013;font-size:1.9;\">";
const Style_ITV1_3_Line = "<span style=\"font-family:'ITV Display Sans Regular';letter-spacing:-0.013;font-size:1.27;\">";
const Style_ITV1_4_Line = "<span style=\"font-family:'ITV Display Sans Regular';letter-spacing:-0.013;font-size:1;\">";
const Style_ITV1_5_Line = "<span style=\"font-family:'ITV Display Sans Regular';letter-spacing:-0.013;font-size:0.55;\">";
//ITV2
const Style_ITV2_1_Line = "<span style=\"font-family:'ITV Display Sans Bold';letter-spacing:-0.02;font-size:3.2;\">";
const Style_ITV2_2_Line = "<span style=\"font-family:'ITV Display Sans Bold';letter-spacing:-0.02;font-size:1.9;\">";
const Style_ITV2_3_Line = "<span style=\"font-family:'ITV Display Sans Bold';letter-spacing:-0.02;font-size:1.28;\">";
const Style_ITV2_4_Line = "<span style=\"font-family:'ITV Display Sans Bold';letter-spacing:-0.02;font-size:1.01;\">";
const Style_ITV2_5_Line = "<span style=\"font-family:'ITV Display Sans Bold';letter-spacing:-0.02;font-size:0.55;\">";
//ITV3
const Style_ITV3_1_Line = "<span style=\"font-family:'ITV Display Sans Medium';letter-spacing:0.105;font-size:2.64;\">";
const Style_ITV3_2_Line = "<span style=\"font-family:'ITV Display Sans Medium';letter-spacing:0.105;font-size:1.89;\">";
const Style_ITV3_3_Line = "<span style=\"font-family:'ITV Display Sans Medium';letter-spacing:0.105;font-size:1.28;\">";
const Style_ITV3_4_Line = "<span style=\"font-family:'ITV Display Sans Medium';letter-spacing:0.105;font-size:0.99;\">";
const Style_ITV3_5_Line = "<span style=\"font-family:'ITV Display Sans Medium';letter-spacing:0.105;font-size:0.55;\">";
//ITV4
const Style_ITV4_1_Line = "<span style=\"font-family:'ITV Display Sans Bold Italic';letter-spacing:-0.01;font-size:2.95;\">";
const Style_ITV4_2_Line = "<span style=\"font-family:'ITV Display Sans Bold Italic';letter-spacing:-0.01;font-size:1.9;\">";
const Style_ITV4_3_Line = "<span style=\"font-family:'ITV Display Sans Bold Italic';letter-spacing:-0.01;font-size:1.29;\">";
const Style_ITV4_4_Line = "<span style=\"font-family:'ITV Display Sans Bold Italic';letter-spacing:-0.01;font-size:0.99;\">";
const Style_ITV4_5_Line = "<span style=\"font-family:'ITV Display Sans Bold Italic';letter-spacing:-0.01;font-size:0.55;\">";
//ITVBe
const Style_ITVBE_1_Line = "<span style=\"font-family:'ITV Display Serif Bold';letter-spacing:-0.01;font-size:3.4;\">";
const Style_ITVBE_2_Line = "<span style=\"font-family:'ITV Display Serif Bold';letter-spacing:-0.01;font-size:1.89;\">";
const Style_ITVBE_3_Line = "<span style=\"font-family:'ITV Display Serif Bold';letter-spacing:-0.01;font-size:1.27;\">";
const Style_ITVBE_4_Line = "<span style=\"font-family:'ITV Display Serif Bold';letter-spacing:-0.01;font-size:0.99;\">";
const Style_ITVBE_5_Line = "<span style=\"font-family:'ITV Display Serif Bold';letter-spacing:-0.01;font-size:0.55;\">";
//ITVX
const Style_ITVX_1_Line = "<span style=\"font-family:'ITV Display Sans Regular';letter-spacing:-0.013;font-size:3.33;\">";
const Style_ITVX_2_Line = "<span style=\"font-family:'ITV Display Sans Regular';letter-spacing:-0.013;font-size:1.9;\">";
const Style_ITVX_3_Line = "<span style=\"font-family:'ITV Display Sans Regular';letter-spacing:-0.013;font-size:1.27;\">";
const Style_ITVX_4_Line = "<span style=\"font-family:'ITV Display Sans Regular';letter-spacing:-0.013;font-size:1;\">";
const Style_ITVX_5_Line = "<span style=\"font-family:'ITV Display Sans Regular';letter-spacing:-0.013;font-size:0.55;\">";

//Create Line style variables based on channel name
eval("var Style_1_Line = Style_" + Channel + "_1_Line");
eval("var Style_2_Line = Style_" + Channel + "_2_Line");
eval("var Style_3_Line = Style_" + Channel + "_3_Line");
eval("var Style_4_Line = Style_" + Channel + "_4_Line");
eval("var Style_5_Line = Style_" + Channel + "_5_Line");

//Time and Extra Info Styles to change the colour
const Style_White_Time = "<span style=\"color:rgb(235,235,235);\">";
const Style_ITV1_Info = "<span style=\"color:rgb(28,203,212);\">";
const Style_ITV2_Info = "<span style=\"color:rgb(221,64,221);\">";
const Style_ITV3_Info = "<span style=\"color:rgb(182,130,235);\">";
const Style_ITV4_Info = "<span style=\"color:rgb(16,235,130);\">";
const Style_ITVBE_Info = "<span style=\"color:rgb(235,145,125);\">";
const Style_ITVX_Info = "<span style=\"color:rgb(222,235,82);\">";

//Create Extra Info style variable based on channel name
eval("var Style_Info = Style_" + Channel + "_Info");

//Concatenate Extra Info and Time. Apply styles and break lines with '^' 
Time.cell.html = (Style_Info + Hidden_Extra_Info.cell.string).split("^").join("<br>") + "<br>"+ 
				 (Style_White_Time + Hidden_Time.cell.string).split("^").join("<br>");

//Copy Time html into additional Time objects
Time_TA_KA.html = Time.cell.html;
Time_TA_NA.html = Time.cell.html;

//===================================================================================================================
//===================================================================================================================

//Update File paths of hidden Primary fields

//File paths
const endboardPath = "C:\\Assets\\Clips\\Endboard_Single\\ENDBOARD_SINGLE_";
var titlePath = "TITLE+IMAGE_";

//Hide/show KeyArt Group if keyArt is blank

var KeyArtFilePath = KeyArt.cell.string;
//var KeyArtisBlank = Boolean(KeyArtFilePath.match(/None_.*?.png/i));
var KeyArtMask = ppFindObject("KeyArt_Mask");
if (KeyArtFilePath === "")
{
		Key_Art_Group.hidden = true;
		No_Key_Art_Group.hidden = false;
		//Change title path
		titlePath = "TITLE_ONLY_";
		//Set 'KA_Check' to "NA" if no key art is available
		KA_Check = "NA";
        ppLog("No Key Art");
	}
	else
	{
		Key_Art_Group.hidden = false;
		No_Key_Art_Group.hidden = true;
       	ppLog("Key Art Available");
}

//Hide/show Text Group and TitleArt Image if TileArt is blank

var TitleArtFilePath = TitleArt.cell.string;
var TitleArtisBlank = Boolean(TitleArtFilePath.match(/None_.*?.png/i));

if (TitleArtisBlank || TitleArtFilePath === "")
{
			TitleArt_Left.hidden = true;
			TitleArt_Centre.hidden = true;
			Group_Title_Text.hidden = false;
			Time_TA_KA.hidden = true;
			Time_TA_NA.hidden = true;
			Time.hidden = false;
			ppLog("No Title Art");
		}
		else
		{
			TitleArt_Left.hidden = false;
			TitleArt_Centre.hidden = false;
			Group_Title_Text.hidden = true;
			Time_TA_KA.hidden = false;
			Time_TA_NA.hidden = false;
			Time.hidden = true;
			ppLog("Title Art Available");
}

//Set path of background clip
ppSetFieldDataByFieldID(200, endboardPath + titlePath + Channel + ".mov");
//Set path of Secondary Text Colour
ppSetFieldDataByFieldID(201, "C:\\Assets\\ITV_Endboards\\Content\\Images\\EB_Colours\\Primary_Colour_"+ Channel +".png");

//===================================================================================================================
//===================================================================================================================
//Set Title Text and find the width

//Title Text in a single string
var Title_Text = Hidden_Title.text;

//Switch Title_Text to caps if set to ITV3 or ITV4
if ((Channel === "ITV3") || (Channel === "ITV4"))
{
	Title_Text = Hidden_Title.text.toUpperCase();
}

//Split Title into array using the ^
var TitleArray = Title_Text.split("^");

//Set the style of 'Hidden_Style' and break the title into mulitple lines
Hidden_Style.cell.html = Style_1_Line + Title_Text.split("^").join("<br>");

//Measure the width of 'Hidden_Style' Object
var Hidden_Style_Width = Hidden_Style.textExtents.max.x - Hidden_Style.textExtents.min.x;
var Hidden_Style_Height = Hidden_Style.textExtents.max.y - Hidden_Style.textExtents.min.y;

//------------------------------------------------------------------
//Update Scale and HTML styles of all text objects

//Maximim Sacale array measured to 100% width of the small bounding box
//Array for different text scales
//With Key Art
const ITV1_Scale_KA_Array = [4.32,7.5,11.2,14.2,25.9];
const ITV2_Scale_KA_Array = [4.32,7.2,10.6,13.5,24.8];
const ITV3_Scale_KA_Array = [4.4,6.1,8.9,11.6,20.8];
const ITV4_Scale_KA_Array = [4.3,6.68,9.78,12.7,22.8];
const ITVBE_Scale_KA_Array = [4.3,7.73,11.4,14.7,26.4];
const ITVX_Scale_KA_Array = [4.32,7.5,11.2,14.2,25.9];
//Without Key Art
const ITV1_Scale_NA_Array = [6.06,10.6,15.8,20.2,36.4];
const ITV2_Scale_NA_Array = [6.06,10.1,15.1,19.1,35];
const ITV3_Scale_NA_Array = [6.17,8.6,12.6,16.3,29.3];
const ITV4_Scale_NA_Array = [6.1,9.4,13.8,18,32.4];
const ITVBE_Scale_NA_Array = [6.06,10.86,16.2,20.8,37.2];
const ITVX_Scale_NA_Array = [6.06,10.6,15.8,20.2,36.4];

//Maximim height array measured to 100% height of the small bounding box
//const ITV1_Height_Array = [2.4,1.72,1.6,1.5,2.1]; (Large Box)
const ITV1_Height_KA_Array = [1.6,1.17,1.08,1.02,1.42];
const ITV2_Height_KA_Array = [1.7,1.18,1.08,1.02,1.42];
const ITV3_Height_KA_Array = [2.07,1.18,1.08,1.02,1.42];
const ITV4_Height_KA_Array = [1.86,1.18,1.08,1.02,1.42];
const ITVBE_Height_KA_Array = [1.6,1.18,1.08,1.02,1.42];
const ITVX_Height_KA_Array = [1.6,1.17,1.08,1.02,1.42];
//Without Key Art
const ITV1_Height_NA_Array = [2.4,1.74,1.6,1.5,2.1];
const ITV2_Height_NA_Array = [2.51,1.76,1.6,1.5,2.1];
const ITV3_Height_NA_Array = [2,1.76,1.6,1.5,2.1];
const ITV4_Height_NA_Array = [3,1.75,1.6,1.5,2.1];
const ITVBE_Height_NA_Array = [2.7,1.74,1.6,1.5,2.1];
const ITVX_Height_NA_Array = [2.4,1.74,1.6,1.5,2.1];

//Set new var name 'Line_01_Scale' based on Channel
//Gives a maximum Width for the scale based on the bounding box
//Uses KA or NA array based on 'KA_Check'
eval("var Line_01_Scale = " + Channel + "_Scale_" + KA_Check + "_Array[0]");
eval("var Line_02_Scale = " + Channel + "_Scale_" + KA_Check + "_Array[1]");
eval("var Line_03_Scale = " + Channel + "_Scale_" + KA_Check + "_Array[2]");
eval("var Line_04_Scale = " + Channel + "_Scale_" + KA_Check + "_Array[3]");
eval("var Line_05_Scale = " + Channel + "_Scale_" + KA_Check + "_Array[4]");

//Set new var name 'Line_01_Height' based on Channel
//Gives a maximum height for the scale based on the bounding box
//Uses KA or NA array based on 'KA_Check'
eval("var Line_01_Height = " + Channel + "_Height_" + KA_Check + "_Array[0]");
eval("var Line_02_Height = " + Channel + "_Height_" + KA_Check + "_Array[1]");
eval("var Line_03_Height = " + Channel + "_Height_" + KA_Check + "_Array[2]");
eval("var Line_04_Height = " + Channel + "_Height_" + KA_Check + "_Array[3]");
eval("var Line_05_Height = " + Channel + "_Height_" + KA_Check + "_Array[4]");

//Update HTML of Title lines 
// 1 Line
Title_1_Line.cell.html = Style_1_Line + TitleArray[0];
// 2 Line
Title_2_Line_01.cell.html = Style_2_Line + TitleArray[0];
Title_2_Line_02.cell.html = Style_2_Line + TitleArray[1];
// 3 Line
Title_3_Line_01.cell.html = Style_3_Line + TitleArray[0];
Title_3_Line_02.cell.html = Style_3_Line + TitleArray[1];
Title_3_Line_03.cell.html = Style_3_Line + TitleArray[2];
// 4 Line
Title_4_Line_01.cell.html = Style_4_Line + TitleArray[0];
Title_4_Line_02.cell.html = Style_4_Line + TitleArray[1];
Title_4_Line_03.cell.html = Style_4_Line + TitleArray[2];
Title_4_Line_04.cell.html = Style_4_Line + TitleArray[3];
// 5 Line
Title_5_Line_01.cell.html = Style_5_Line + TitleArray[0];
Title_5_Line_02.cell.html = Style_5_Line + TitleArray[1];
Title_5_Line_03.cell.html = Style_5_Line + TitleArray[2];
Title_5_Line_04.cell.html = Style_5_Line + TitleArray[3];
Title_5_Line_05.cell.html = Style_5_Line + TitleArray[4];

//Update Scale of text objects
//Check to see if the scale is bigger than the maximum height
// 1 Line
Title_1_Line.scale.x = Math.min((Line_01_Scale/Hidden_Style_Width),Line_01_Height);
Title_1_Line.scale.y = Title_1_Line.scale.x;
// 2 Line
Group_Title_2_Line.scale.x = Math.min((Line_02_Scale/Hidden_Style_Width),Line_02_Height);
Group_Title_2_Line.scale.y = Group_Title_2_Line.scale.x;
// 3 Line
Group_Title_3_Line.scale.x = Math.min((Line_03_Scale/Hidden_Style_Width),Line_03_Height);
Group_Title_3_Line.scale.y = Group_Title_3_Line.scale.x;
// 4 Line
Group_Title_4_Line.scale.x = Math.min((Line_04_Scale/Hidden_Style_Width),Line_04_Height);
Group_Title_4_Line.scale.y = Group_Title_4_Line.scale.x;
// 5 Line
Group_Title_5_Line.scale.x = Math.min((Line_05_Scale/Hidden_Style_Width), Line_05_Height);
Group_Title_5_Line.scale.y = Group_Title_5_Line.scale.x;



//===================================================================================================================
//===================================================================================================================

//Hide/show titles based on number of lines

//Count the number of lines
var LineCount = (Title_Text.split("^").length);

//set to 1 line by default
Title_1_Line.hidden = false;
Group_Title_2_Line.hidden = true;
Group_Title_3_Line.hidden = true;
Group_Title_4_Line.hidden = true;
Group_Title_5_Line.hidden = true;

//Hide/show titles using 'LineCount'
if (LineCount == 2)
{
	Title_1_Line.hidden = true;
	Group_Title_2_Line.hidden = false;
	Group_Title_3_Line.hidden = true;
	Group_Title_4_Line.hidden = true;
	Group_Title_5_Line.hidden = true;
}
else if (LineCount == 3)
{
	Title_1_Line.hidden = true;
	Group_Title_2_Line.hidden = true;
	Group_Title_3_Line.hidden = false;
	Group_Title_4_Line.hidden = true;
	Group_Title_5_Line.hidden = true;
}
else if (LineCount == 4)
{
	Title_1_Line.hidden = true;
	Group_Title_2_Line.hidden = true;
	Group_Title_3_Line.hidden = true;
	Group_Title_4_Line.hidden = false;
	Group_Title_5_Line.hidden = true;
}
else if (LineCount >= 5)
{
	Title_1_Line.hidden = true;
	Group_Title_2_Line.hidden = true;
	Group_Title_3_Line.hidden = true;
	Group_Title_4_Line.hidden = true;
	Group_Title_5_Line.hidden = false;
}



//===================================================================================================================
//===================================================================================================================







//===================================================================================================================
//===================================================================================================================
//Logs
ppLog("Channel: " + Channel);
ppLog("Number of lines: " + LineCount);
//ppLog("Background path: " + endboardPath + titlePath + Channel + ".mov");
//ppLog("Colour path: " + "<JobPath>\\Content\\Images\\EB_Colours\\"+ Channel +"_Secondary_Colour.png");
ppLog("Key Art path: " + KeyArt.cell.string);
ppLog("Title Art path: " + TitleArt.cell.string);
//ppLog("Hidden Style Width: " + Hidden_Style_Width);
ppLog("----------------------------------------------");

