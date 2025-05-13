//Declare Variables
//Text Objects
var TITLE_01_SINGLE = ppFindObject("TITLE_01_SINGLE");
var TITLE_02_SINGLE = ppFindObject("TITLE_02_SINGLE");
var TITLE_03_SINGLE = ppFindObject("TITLE_03_SINGLE");
var TITLE_04_SINGLE = ppFindObject("TITLE_04_SINGLE");
var TITLE_05_SINGLE = ppFindObject("TITLE_05_SINGLE");
var TITLE_06_SINGLE = ppFindObject("TITLE_06_SINGLE");
var TITLE_07_SINGLE = ppFindObject("TITLE_07_SINGLE");

var TITLE_01_DOUBLE = ppFindObject("TITLE_01_DOUBLE");
var TITLE_02_DOUBLE = ppFindObject("TITLE_02_DOUBLE");
var TITLE_03_DOUBLE = ppFindObject("TITLE_03_DOUBLE");
var TITLE_04_DOUBLE = ppFindObject("TITLE_04_DOUBLE");
var TITLE_05_DOUBLE = ppFindObject("TITLE_05_DOUBLE");
var TITLE_06_DOUBLE = ppFindObject("TITLE_06_DOUBLE");
var TITLE_07_DOUBLE = ppFindObject("TITLE_07_DOUBLE");

var TITLE_02_SMALL = ppFindObject("TITLE_02_SMALL");
var TITLE_03_SMALL = ppFindObject("TITLE_03_SMALL");
var TITLE_04_SMALL = ppFindObject("TITLE_04_SMALL");
var TITLE_05_SMALL = ppFindObject("TITLE_05_SMALL");
var TITLE_06_SMALL = ppFindObject("TITLE_06_SMALL");
var TITLE_07_SMALL = ppFindObject("TITLE_07_SMALL");

var PROMO_02_SMALL = ppFindObject("PROMO_02_SMALL");
var PROMO_03_SMALL = ppFindObject("PROMO_03_SMALL");
var PROMO_04_SMALL = ppFindObject("PROMO_04_SMALL");
var PROMO_05_SMALL = ppFindObject("PROMO_05_SMALL");
var PROMO_06_SMALL = ppFindObject("PROMO_06_SMALL");
var PROMO_07_SMALL = ppFindObject("PROMO_07_SMALL");

//Set show single by default
TITLE_01_SINGLE.hidden = false;
TITLE_02_SINGLE.hidden = false;
TITLE_03_SINGLE.hidden = false;
TITLE_04_SINGLE.hidden = false;
TITLE_05_SINGLE.hidden = false;
TITLE_06_SINGLE.hidden = false;
TITLE_07_SINGLE.hidden = false;
//Hide double by default
TITLE_01_DOUBLE.hidden = true;
TITLE_02_DOUBLE.hidden = true;
TITLE_03_DOUBLE.hidden = true;
TITLE_04_DOUBLE.hidden = true;
TITLE_05_DOUBLE.hidden = true;
TITLE_06_DOUBLE.hidden = true;
TITLE_07_DOUBLE.hidden = true;
//Reset offset by default
PROMO_02_SMALL.offset.y = 0;
PROMO_03_SMALL.offset.y = 0;
PROMO_04_SMALL.offset.y = 0;
PROMO_05_SMALL.offset.y = 0;
PROMO_06_SMALL.offset.y = 0;
PROMO_07_SMALL.offset.y = 0;

//--------------------------------------------------------------------------
//Table script
//These are now arrays to allow event handler function to be generic
//Title Single
let Title = new Array(5);
Title[1] = ppFindObject("TITLE_01_SINGLE");
Title[2] = ppFindObject("TITLE_02_SINGLE");
Title[3] = ppFindObject("TITLE_03_SINGLE");
Title[4] = ppFindObject("TITLE_04_SINGLE");
//Title Single Loop
let Title_Loop = new Array(5);
Title_Loop[1] = ppFindObject("TITLE_05_SINGLE");
Title_Loop[2] = ppFindObject("TITLE_06_SINGLE");
Title_Loop[3] = ppFindObject("TITLE_07_SINGLE");
Title_Loop[4] = ppFindObject("TITLE_08_SINGLE");
//Title Double
let Title_Double = new Array(5);
Title_Double[1] = ppFindObject("TITLE_01_DOUBLE");
Title_Double[2] = ppFindObject("TITLE_02_DOUBLE");
Title_Double[3] = ppFindObject("TITLE_03_DOUBLE");
Title_Double[4] = ppFindObject("TITLE_04_DOUBLE");
//Title Double Loop
let Title_Double_Loop = new Array(5);
Title_Double_Loop[1] = ppFindObject("TITLE_05_DOUBLE");
Title_Double_Loop[2] = ppFindObject("TITLE_06_DOUBLE");
Title_Double_Loop[3] = ppFindObject("TITLE_07_DOUBLE");
Title_Double_Loop[4] = ppFindObject("TITLE_08_DOUBLE");
//Title Small
let Title_Small = new Array(5);
Title_Small[1] = ppFindObject("TITLE_01_SMALL");
Title_Small[2] = ppFindObject("TITLE_02_SMALL");
Title_Small[3] = ppFindObject("TITLE_03_SMALL");
Title_Small[4] = ppFindObject("TITLE_04_SMALL");
//Title Small_Loop
let Title_Small_Loop = new Array(5);
Title_Small_Loop[1] = ppFindObject("TITLE_05_SMALL");
Title_Small_Loop[2] = ppFindObject("TITLE_06_SMALL");
Title_Small_Loop[3] = ppFindObject("TITLE_07_SMALL");
Title_Small_Loop[4] = ppFindObject("TITLE_08_SMALL");
//Time
let Time = new Array(5);
Time[1] = ppFindObject("TIME_01");
Time[2] = ppFindObject("TIME_02");
Time[3] = ppFindObject("TIME_03");
Time[4] = ppFindObject("TIME_04");
//Time Loop
let Time_Loop = new Array(5);
Time_Loop[1] = ppFindObject("TIME_05");
Time_Loop[2] = ppFindObject("TIME_06");
Time_Loop[3] = ppFindObject("TIME_07");
Time_Loop[4] = ppFindObject("TIME_08");
//Time_Small
let Time_Small = new Array(5);
Time_Small[1] = ppFindObject("INFO_01_SMALL");
Time_Small[2] = ppFindObject("INFO_02_SMALL");
Time_Small[3] = ppFindObject("INFO_03_SMALL");
Time_Small[4] = ppFindObject("INFO_04_SMALL");
//Time_Small Loop
let Time_Small_Loop = new Array(5);
Time_Small_Loop[1] = ppFindObject("INFO_05_SMALL");
Time_Small_Loop[2] = ppFindObject("INFO_06_SMALL");
Time_Small_Loop[3] = ppFindObject("INFO_07_SMALL");
Time_Small_Loop[4] = ppFindObject("INFO_08_SMALL");
//Item counter
var Counter = 0;
var Counter_Text = ppFindObject("Counter_Text");
//Set Counter on screen
Counter_Text.cell.string = Counter;
//Blank Image
var Blank = "\\\\localhost\\Assets\\Images\\SVT1-Lineup-Fallback-Image.png";
var BlankBlur = "\\\\localhost\\Assets\\Images\\SVT1-Lineup-Fallback-Image-blur.png";
var Blank2x3 = "\\\\localhost\\Assets\\Images\\SVT1-Lineup-Fallback-Image-2x3.png";

//Get JSON Data
var JSON_Field = ppFindFieldMarkerByFieldID(100);
var JSON_Field_Data = JSON_Field.fieldMarker_FieldData;
//Log the incoming field data for debugging purposes
ppLog(JSON_Field_Data);
//Initialise these variables to nothing in case there was no field data
var jsonData = undefined;
var ScheduleLength = 0;
//Check the length of the incoming field data before attempting to read it as JSON
if (JSON_Field_Data.length > 0) {
    jsonData = JSON.parse(JSON_Field_Data);
    ScheduleLength = jsonData.length;
}
//Run update data at start
ppOnEvent_Program(1);
ppOnEvent_Program(2);
//ppOnEvent_Program(3);
//ppOnEvent_Program(4);
ppOnEvent_TextUpdate();

//--------------------------------------------------------------------------
//Fucntion to update single or double line based on length of title
function ppOnEvent_TextUpdate()
{
	
	//Set show single by default
	TITLE_01_SINGLE.hidden = false;
	TITLE_02_SINGLE.hidden = false;
	TITLE_03_SINGLE.hidden = false;
	TITLE_04_SINGLE.hidden = false;
	TITLE_05_SINGLE.hidden = false;
	TITLE_06_SINGLE.hidden = false;
	TITLE_07_SINGLE.hidden = false;
	//Hide double by default
	TITLE_01_DOUBLE.hidden = true;
	TITLE_02_DOUBLE.hidden = true;
	TITLE_03_DOUBLE.hidden = true;
	TITLE_04_DOUBLE.hidden = true;
	TITLE_05_DOUBLE.hidden = true;
	TITLE_06_DOUBLE.hidden = true;
	TITLE_07_DOUBLE.hidden = true;
	//Reset offset by default
	PROMO_02_SMALL.offset.y = 0;
	PROMO_03_SMALL.offset.y = 0;
	PROMO_04_SMALL.offset.y = 0;
	PROMO_05_SMALL.offset.y = 0;
	PROMO_06_SMALL.offset.y = 0;
	PROMO_07_SMALL.offset.y = 0;

	//Hide/unhide groups if double line
	if (TITLE_01_SINGLE.height > 1){
			TITLE_01_SINGLE.hidden = true;
			TITLE_01_DOUBLE.hidden = false;}
	if (TITLE_02_SINGLE.height > 1){
			TITLE_02_SINGLE.hidden = true;
			TITLE_02_DOUBLE.hidden = false;}
	if (TITLE_03_SINGLE.height > 1){
			TITLE_03_SINGLE.hidden = true;
			TITLE_03_DOUBLE.hidden = false;}
	if (TITLE_04_SINGLE.height > 1){
			TITLE_04_SINGLE.hidden = true;
			TITLE_04_DOUBLE.hidden = false;}
	if (TITLE_05_SINGLE.height > 1){
			TITLE_05_SINGLE.hidden = true;
			TITLE_05_DOUBLE.hidden = false;}
	if (TITLE_06_SINGLE.height > 1){
			TITLE_06_SINGLE.hidden = true;
			TITLE_06_DOUBLE.hidden = false;}
	if (TITLE_07_SINGLE.height > 1){
			TITLE_07_SINGLE.hidden = true;
			TITLE_07_DOUBLE.hidden = false;}
	if (TITLE_02_SMALL.height > 0.32){
			PROMO_02_SMALL.offset.y = 0.319;}
	if (TITLE_03_SMALL.height > 0.32){
			PROMO_03_SMALL.offset.y = 0.319;}
	if (TITLE_04_SMALL.height > 0.32){
			PROMO_04_SMALL.offset.y = 0.319;}
	if (TITLE_05_SMALL.height > 0.32){
			PROMO_05_SMALL.offset.y = 0.319;}
	if (TITLE_06_SMALL.height > 0.32){
			PROMO_06_SMALL.offset.y = 0.319;}
	if (TITLE_07_SMALL.height > 0.32){
			PROMO_07_SMALL.offset.y = 0.319;}
}

//--------------------------------------------------------------------------
function ppOnEvent_Program(n_ProgramNumber) {
	var Image_Path = Blank;
	var Hint_Path = Blank2x3;
	var Background_Path = BlankBlur;

    var Image_Text_Tmp = "Missing";
    var HintText_Tmp = "Missing";
    var Background_Text_Tmp = "Missing";

    //var Title_Text = "Title Blank";
    //var Time_Text = "Time Blank";

    //check counter value
    //Remember counter unit starts at 1 and goes up to number of elements in the
    // JSON data, but access to the JSON array starts at index 0, so we should use -1
    // when accessing it.
    Counter = Counter + 1;
	ppLog(Counter);
    if (Counter > ScheduleLength) {
        //Update Counter
        Counter = 1;
		
    }
    Counter_Text.cell.string = Counter;
    //If we have valid JSON data for this counter value then query it
    // otherwise stick with defaults
    if (jsonData != undefined && Counter <= jsonData.length) {
        //Get the data values from the JSON (using -1 of Counter as described above)
		//Set temporary image paths by default
        var Image_Path_Tmp = jsonData[Counter - 1].ProgramImage;
        var Hint_Path_Tmp = jsonData[Counter - 1].ProgramImageHint;
        var Background_Path_Tmp = jsonData[Counter - 1].ProgramImageBackground;
		//Text Objects
        Title_Text = jsonData[Counter - 1].ProgramTitle;
        Time_Text = jsonData[Counter - 1].DisplayTime;
        Timecode_Text = jsonData[Counter - 1].StartTimecode;
        //Check if the file exists, if it does we use the path
        // otherwise we stick with the default blank
		//16x9 Image
        if ((ppFileExists(Image_Path_Tmp)) == true) {
			//Temporary paths for images
			Image_Text_Tmp = Image_Path = Image_Path_Tmp;
        } else {
            ppLog("Image Missing : " + Image_Path_Tmp);
        }
		//2x3 Image
        if ((ppFileExists(Hint_Path_Tmp)) == true) {
			//Temporary paths for images
			Hint_Text_Tmp = Hint_Path = Hint_Path_Tmp;

        } else {
            ppLog("Image Missing : " + Hint_Path_Tmp);
        }
		//Blur Image
        if ((ppFileExists(Background_Path_Tmp)) == true) {
			//Temporary paths for images
            Background_Text_Tmp = Background_Path = Background_Path_Tmp;
        } else {
            ppLog("Image Missing : " + Background_Path_Tmp);
        }
        //Output some debug
        ppLog("Program " + n_ProgramNumber+ " Image path 	: " + Image_Path);
        ppLog("Program " + n_ProgramNumber + " Title 		: " + Title_Text);
        ppLog("Program " + n_ProgramNumber+ " Time 		: " + Time_Text);
        ppLog("Program " + n_ProgramNumber+ " Timecode 	: " + Timecode_Text);

        //Set the data to the fields and objects
		//Image Fields
        ppSetFieldDataByFieldID(120 + n_ProgramNumber, Image_Path);
        ppSetFieldDataByFieldID(130 + n_ProgramNumber, Hint_Path);
        ppSetFieldDataByFieldID(140 + n_ProgramNumber, Background_Path);

		//Text Fields
        Title[n_ProgramNumber].cell.string = Title_Text;
        Title_Double[n_ProgramNumber].cell.string = Title_Text;
        Title_Small[n_ProgramNumber].cell.string = Title_Text;
        Time[n_ProgramNumber].cell.string = Time_Text;
        Time_Small[n_ProgramNumber].cell.string = Time_Text;

		//Loop versions
        Title_Loop[n_ProgramNumber].cell.string = Title_Text;
        Time_Loop[n_ProgramNumber].cell.string = Time_Text;
        Title_Double_Loop[n_ProgramNumber].cell.string = Title_Text;
        Title_Small_Loop[n_ProgramNumber].cell.string = Title_Text;
        Time_Small_Loop[n_ProgramNumber].cell.string = Time_Text;
    }
	ppOnEvent_TextUpdate();
}