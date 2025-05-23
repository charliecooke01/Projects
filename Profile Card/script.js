//connect to button
const btn = document.getElementById("btn");



//click event
btn.addEventListener("click", function () {
  getPerson(getData);

  //Give random job title from array
  var textArray = [
    "Web Developer",
    "Sales Executive",
    "Marketing Manager",
    "Graphic Designer",
    "QA Tester",
    "Managing Director",
    "HR Manager"
  ]
  var randomJob = Math.floor(Math.random() * textArray.length);
  document.getElementById("job").innerHTML = textArray[randomJob];

});

//get data function
function getPerson(cb) {
  const url = "https://randomuser.me/api/";
  const request = new XMLHttpRequest();

  //check if url connection works
  request.open("GET", url, true);
  request.onload = function () {
    //if true get data
    if (this.status === 200) {
      cb(this.responseText, showData);
    }
  };
  //send data request
  request.send();
}

//parse JSON data
function getData(response, cb) {
  const data = JSON.parse(response);

  const {
    name: { first },
    name: { last },
    picture: { large },
    phone,
    email,
  } = data.results[0];
  cb(first, last, large, phone, email);
}

//connect data to elements
function showData(first, last, large, phone, email) {
  document.getElementById("name").textContent = `${first} ${last}`;
  document.getElementById("phone").textContent = phone;
  document.getElementById("email").textContent = email;
  document.getElementById("photo").src = large;
}