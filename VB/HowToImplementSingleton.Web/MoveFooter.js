var DXagent = navigator.userAgent.toLowerCase();
var DXopera = (DXagent.indexOf("opera") > -1);
var DXsafari = DXagent.indexOf("safari") > -1;
var DXie = (DXagent.indexOf("msie") > -1 && !DXopera);
var DXns = (DXagent.indexOf("mozilla") > -1 || DXagent.indexOf("netscape") > -1 || DXagent.indexOf("firefox") > -1) && !DXsafari && !DXie && !DXopera;

function DXattachEventToElement(element, eventName, func) {
    if(DXns || DXsafari)
        element.addEventListener(eventName, func, true);
    else {
        if(eventName.toLowerCase().indexOf("on") != 0) 
            eventName = "on"+eventName;
        element.attachEvent(eventName, func);
    }
}
 
function isIE() {
    return (document.all && !window.opera) ? true : false;
}
function movefooter() { 
    var footer = document.getElementById("Footer");
    var spacer = document.getElementById("Spacer");
    var heightWindow = window.document.body.clientHeight;
    var heightBody = footer.offsetHeight + footer.offsetTop - spacer.offsetHeight;
    var height = heightWindow - heightBody;
    spacer.height = height;
    if (Math.abs(spacer.height) == spacer.height)  {
        spacer.style.height = spacer.height + "px";
    }
}

function DXWindowOnResize(evt){
	movefooter();
}
