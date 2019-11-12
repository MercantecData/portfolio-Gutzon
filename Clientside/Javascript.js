function onload(){
clockload();
}

function buttonclick(button,url){
    var iframe = document.getElementsByClassName("iframe")[0];
    if (button.className == "My_Button Viewing")
    {
        iframe.src = "";
        button.className = "My_Button";
        button.innerHTML = "Preview";
    }
    else 
    {
        if (document.getElementsByClassName("My_Button Viewing").length > 0){
            document.getElementsByClassName("My_Button Viewing")[0].innerHTML = "Preview";
            document.getElementsByClassName("My_Button Viewing")[0].className = "My_Button";
        }
        button.className = "My_Button Viewing";
        button.innerHTML = "Close Preview";
        iframe.src = url;
    }

}

//Ur begynder her.
var canvas;
var ctx;
var radius;

function clockload(){
    canvas = document.getElementById("ur");
    ctx = canvas.getContext("2d");
    ctx.canvas.width  = 250;
    ctx.canvas.height = 250;
    radius = canvas.height / 2;
    setInterval(drawClock, 15);

}
function drawClock() {
	ctx.canvas.height = 250;
	radius = canvas.height / 2;
	ctx.translate(radius, radius);
	radius = radius * 0.90;
	drawFace(ctx, radius);
	drawTime(ctx, radius); 
}

function drawFace(ctx, radius) {
  ctx.beginPath();
  ctx.arc(0, 0, radius, 0, 2*Math.PI);
  ctx.fillStyle = 'black';
  ctx.fill();
  ctx.beginPath();
  ctx.arc(0, 0, (radius*0.07)/2, 0, 2*Math.PI);
  ctx.fillStyle = 'white';
  ctx.fill();
  var ang;
  ctx.strokeStyle = "gray";
  ctx.lineWidth = radius*0.005;
  ctx.lineCap = "square";
  ctx.textBaseline="middle";
  ctx.textAlign="center";
  ctx.fillStyle = "white";
  for(num = 1; num < 35; num++){
	ang = num * Math.PI / (6*5);
	ctx.rotate(ang);
    if (num != 5 && num != 10 && num != 15 && num != 20 && num != 25 && num != 30){
		ctx.moveTo(0, -radius*0.96);
		ctx.lineTo(0, -radius);
		ctx.rotate(-ang*2);
		ctx.moveTo(0, -radius*0.96);
		ctx.lineTo(0, -radius);
		ctx.stroke();
	}
	else {
		ctx.translate(0, -radius*0.75);
		ctx.rotate(-ang);
		ctx.font = radius*.30 + "px Roadgeek2014SeriesC";
		ctx.fillText(num.toString()/5, 0, 0);
		ctx.rotate(ang);
		ctx.translate(0, -radius*0.20);
		ctx.rotate(-ang);
		ctx.font = radius*.10 + "px Roadgeek2014SeriesC";
		ctx.fillText(num.toString(), 0, 0);
		ctx.rotate(ang);
		ctx.translate(0, radius*0.95);
		ctx.rotate(-ang*2);
		ctx.translate(0, -radius*0.95);
		ctx.rotate(ang);
		ctx.fillText(60-num.toString(), 0, 0);
		ctx.rotate(-ang);
		ctx.translate(0, radius*0.20);
		ctx.rotate(ang);
		ctx.font = radius*.30 + "px Roadgeek2014SeriesC";
		ctx.fillText(12-num.toString()/5, 0, 0);
		ctx.rotate(-ang);
		ctx.translate(0, radius*0.75);
	}
	ctx.rotate(ang);
  }
  ctx.fillText(12, 0, -radius*0.75);
  ctx.font = radius*.10 + "px Roadgeek2014SeriesC";
  ctx.fillText(60, 0, -radius*0.95);
}


function drawTime(ctx, radius){
    var now = new Date();
    var hour = now.getHours();
    var minute = now.getMinutes();
    var second = now.getSeconds() + (now.getMilliseconds()/1000);
    //Timer
    hour=hour%12;
    hour=(hour*Math.PI/6)+
    (minute*Math.PI/(6*60))+
    (second*Math.PI/(360*60));
    drawHand(ctx, hour, radius*0.5, radius*0.02, radius*0.07, 0, "White", radius);
    //Minuter
    minute=(minute*Math.PI/30)+(second*Math.PI/(30*60));
    drawHand(ctx, minute, radius*0.85, radius*0.02, radius*0.07, 0, "White", radius);
    // Sekunder
    second=(second*Math.PI/30);
    drawHand(ctx, second, radius*0.99, radius*0.007, radius*0.007, radius*0.10, "Red", radius);
	ctx.beginPath();
    ctx.arc(0, 0, (radius/40), 0, 2*Math.PI);
    ctx.fillStyle = "red";
    ctx.fill();
	ctx.beginPath();
    ctx.arc(0, 0, (radius/80), 0, 2*Math.PI);
    ctx.fillStyle = "Black";
    ctx.fill();
}

function drawHand(ctx, pos, length, width1, width2, tail, Color, radius) {
    ctx.strokeStyle = Color;
    ctx.beginPath();
    ctx.lineWidth = width1;
    ctx.lineCap = "round";
    ctx.rotate(pos);
	ctx.moveTo(0,+tail);
    ctx.lineTo(0,-radius*0.20);
	ctx.stroke();
	ctx.beginPath();
	ctx.moveTo(0,-radius*0.20);
	ctx.lineWidth = width2;
	ctx.lineTo(0,-length);
    ctx.stroke();
    ctx.rotate(-pos);

}
//Ur slutter her